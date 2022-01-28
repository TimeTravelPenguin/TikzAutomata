#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: Figure.cs
// 
// Current Data:
// 2022-01-28 10:43 PM
// 
// Creation Date:
// 2022-01-21 11:05 PM

#endregion

#region usings

#endregion

#region usings

using System;
using System.Collections.Generic;
using TikzAutomata.TikzFigure.Edges;
using TikzAutomata.TikzFigure.Nodes;
using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure
{
  public class Figure : IFigure, IStyleable
  {
    private readonly List<IEdge> _figureEdges = new();
    private readonly List<INode> _figureNodes = new();

    public IReadOnlyCollection<INode> GetNodes()
    {
      return _figureNodes.AsReadOnly();
    }

    public IReadOnlyCollection<IEdge> GetEdges()
    {
      return _figureEdges.AsReadOnly();
    }

    public void AddNode(INode node)
    {
      _figureNodes.Add(node);
    }

    public void AddEdge(IEdge edge)
    {
      _figureEdges.Add(edge);
    }

    public void ApplyStyle(string styleName)
    {
      throw new NotImplementedException();
    }

    public void ApplyStyle(IStyle style)
    {
      throw new NotImplementedException();
    }
  }
}