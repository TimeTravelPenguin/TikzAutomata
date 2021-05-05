# TikzGraph

A C# library that is designed to generate code for graph plots for LaTeX documents.

As an example, observe the following graph:

<img src="./images/nn_example.png" width=500px />

In LaTeX, it is made from the following code:

```latex
\usepackage{tikz}

\begin{figure}
  \centering
    \begin{tikzpicture}
        \node[state] (b) {$1$};
        \node[state, below of=b] (x1) {$1.1$};
        \node[state, below of=x1] (x2) {$0.5$};
        \node[state, right of=x1] (L) {$\mathcal{L}$};
        \node[state, right of=L] (y) {$\hat{y}$};

        \draw (b) edge[above] node[yshift=3mm] {$1.05$} (L)
              (x1) edge[above] node[] {$-0.15$} (L)
              (x2) edge[below] node[yshift=-3mm] {$0.8$} (L)
              (L) edge[above] node[] {$0.984$} (y)
        ;
    \end{tikzpicture}
  \caption{A simple neural network}
  \label{fig:simple_nn}
\end{figure}
```

The above code is generated using this library from the following:

```cs
var inputNodeB = new TikzNode("b", "1");
var inputNodeX1 = new TikzNode("x1", "1.1");
var inputNodeX2 = new TikzNode("x2", "0.5");

var NodeL = new TikzNode("L", @"\mathcal{L}");
var NodeY = new TikzNode("y", @"\hat{y}");

var edgeBL = new TikzEdge("1.05", yShift: 3);
var edgeX1L = new TikzEdge("-0.15");
var edgeX2L = new TikzEdge("0.8", textDirection: Direction.Below, yShift: -3);
var edgeLY = new TikzEdge("0.984");

var figure = new TikzFigure("A simple neural network", "simple_nn", inputNodeB);

figure.AddNode(inputNodeX1, inputNodeB, Direction.Below);
figure.AddNode(inputNodeX2, inputNodeX1, Direction.Below);

figure.AddNode(NodeL, inputNodeX1, Direction.Right);
figure.AddNode(NodeY, NodeL, Direction.Right);

figure.AddEdge(edgeBL, inputNodeB, NodeL);
figure.AddEdge(edgeX1L, inputNodeX1, NodeL);
figure.AddEdge(edgeX2L, inputNodeX2, NodeL);
figure.AddEdge(edgeLY, NodeL, NodeY);

var tikz = figure.Build();
Console.WriteLine(tikz);
```

---

## TODO

### Planned refactors

- Simplify edge-node relationships. Proposed coding semantic:
  
  ```cs
  var nodeA = new Node();
  var nodeB = new Node();
  var nodeC = new Node();

  figure = new Figure(nodeA);

  // Attach edges via extensions
  nodeA.SharesEdgeWith(nodeB)
       .WithProperties( /* Edge properties*/ );

  // Can return edge object reference     
  var edgeAC = nodeA.SharesEdgeWith(nodeC);

  figure.Build();
  ```

### Planned implementations

- Support edge styling options. e.g. specify arrows `'<->'`, `'->'`, `'<-'`, and `'-'`.
- Support self-loops / edges to self, along with the appropriate styling options.
