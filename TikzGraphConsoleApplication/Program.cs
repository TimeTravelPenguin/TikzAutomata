#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraphConsoleApplication
// File Name: Program.cs
// 
// Current Data:
// 2021-05-04 7:06 PM
// 
// Creation Date:
// 2021-05-03 10:47 PM

#endregion

#region usings

using System;
using TikzGraph;
using TikzGraph.TikzObjects;

#endregion

namespace TikzGraphConsoleApplication
{
  public static class Program
  {
    public static void Main()
    {
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
    }
  }
}