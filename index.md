# Tikz Automata

<div class="feature_image">
  <img src="./assets/images/Favicon_Big.png"/>
  TikzAutomata is a C# library designed to assist in building Tikz figures. Large figures can become complex and prone to errors and typos, which may cause long delays in the development cycle of other work.
  Building your figures using this C# library provides you the ability to build using objects and prevent the issue of figure-breaking typos.
</div>

> [!NOTE]
> TikzAutonoma is currently still in very early development. Please note that there is minimal functionality beyond basic plots,
> and currently still causes some occasional issues on figure generation.

## What is Tikz?

```latex
\usepackage{tikz}
\usetikzlibrary{automata, positioning, arrows}

\tikzset{%
    ->,
    >=stealth',
    node distance=2cm,
    .every state/.style={thick, fill=gray!10},
    initial text=$ $,
}

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

```cs
var inputNodeB = new TikzNode("b", "1");
var inputNodeX1 = new TikzNode("x1", "1.1");
var inputNodeX2 = new TikzNode("x2", "0.5");

var nodeL = new TikzNode("L", @"\mathcal{L}");
var nodeL = new TikzNode("y", @"\hat{y}");

var edgeBL = new TikzEdge("1.05", yShift: 3);
var edgeX1L = new TikzEdge("-0.15");
var edgeX2L = new TikzEdge("0.8", textDirection: Direction.Below, yShift: -3);
var edgeLY = new TikzEdge("0.984");

var figure = new TikzFigure("A simple neural network", "simple_nn", inputNodeB);

figure.AddNode(inputNodeX1, inputNodeB, Direction.Below);
figure.AddNode(inputNodeX2, inputNodeX1, Direction.Below);

figure.AddNode(nodeL, inputNodeX1, Direction.Right);
figure.AddNode(nodeL, nodeL, Direction.Right);

figure.AddEdge(edgeBL, inputNodeB, nodeL);
figure.AddEdge(edgeX1L, inputNodeX1, nodeL);
figure.AddEdge(edgeX2L, inputNodeX2, nodeL);
figure.AddEdge(edgeLY, nodeL, nodeL);

var tikz = figure.Build();
Console.WriteLine(tikz);
```