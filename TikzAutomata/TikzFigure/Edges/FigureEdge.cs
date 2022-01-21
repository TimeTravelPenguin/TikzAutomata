#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureEdge.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:05 AM

#endregion

#region usings

using System;
using TikzAutomata.TikzFigure.Base;
using TikzAutomata.TikzFigure.Nodes;
using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure.Edges
{
  public sealed class FigureEdge : FigureObjectBase, IEdge
  {
    public FigureEdge(string id, string text, INode nodeTip,
      INode nodeTail, Bend bendDirection = Bend.None)
    {
      Id = id;
      Text = text;
      NodeTip = nodeTip;
      NodeTail = nodeTail;
      BendDirection = bendDirection;
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
    public Bend BendDirection { get; set; }

    #endregion
  }
}