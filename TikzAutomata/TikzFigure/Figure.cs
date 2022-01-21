﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: Figure.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:05 PM

#endregion

#region usings

#endregion

#region usings

using System;
using System.Collections.Generic;
using TikzAutomata.Abstractions;

#endregion

namespace TikzAutomata.TikzFigure
{
  public class Figure : IFigure, IStyleable, IEncodeable
  {
    private readonly List<IEdge> _figureEdges = new();
    private readonly List<INode> _figureNodes = new();

    public string Encode()
    {
      throw new NotImplementedException();
    }

    public void AddNode(INode node)
    {
      _figureNodes.Add(node);
    }

    public void AddEdge(IEdge edge)
    {
      throw new NotImplementedException();
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