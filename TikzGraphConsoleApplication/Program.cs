#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraphConsoleApplication
// File Name: Program.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
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
      var inputNodeA = new TikzNode("nodeA", "1");
      var inputNodeB = new TikzNode("nodeB", "1.1");
      var inputNodeC = new TikzNode("nodeC", "0.5");

      var activationNode = new TikzNode("nodeActivation", @"\mathcal{L}");
      var yhat = new TikzNode("yHat", @"\hat{y}");

      var edgeAL = new TikzEdge("1.05");
      var edgeBL = new TikzEdge("-0.15");
      var edgeCL = new TikzEdge("0.8");
      var edgeLy = new TikzEdge("0.984");

      var figure = new TikzFigure("A simple neural network", "nn_demo", inputNodeA);

      figure.AddNode(inputNodeB, inputNodeA, Direction.Below);
      figure.AddNode(inputNodeC, inputNodeB, Direction.Below);

      figure.AddNode(activationNode, inputNodeB, Direction.Right);
      figure.AddNode(yhat, activationNode, Direction.Right);

      figure.AddEdge(edgeAL, inputNodeA, activationNode);
      figure.AddEdge(edgeBL, inputNodeB, activationNode);
      figure.AddEdge(edgeCL, inputNodeC, activationNode);
      figure.AddEdge(edgeLy, activationNode, yhat);

      var exp = figure.Build();
      Console.WriteLine(exp);
    }
  }
}