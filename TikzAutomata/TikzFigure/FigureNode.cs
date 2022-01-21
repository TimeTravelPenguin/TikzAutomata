﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureNode.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:05 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutomata.TikzFigure
{
  public sealed class FigureNode : FigureObjectBase, IEdge
  {
    public FigureNode(string id, string text)
    {
      Id = id;
      Text = text;
    }

    #region Overrides of FigureObjectBase

    public override void ApplyStyle(string styleName)
    {
      throw new NotImplementedException();
    }

    public override void ApplyStyle(IStyle style)
    {
      throw new NotImplementedException();
    }

    #endregion

    #region Implementation of IEdge

    public INode NodeTip { get; set; }
    public INode NodeTail { get; set; }

    #endregion
  }
}