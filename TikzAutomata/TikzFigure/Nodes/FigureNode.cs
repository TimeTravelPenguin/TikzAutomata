#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureNode.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:06 AM

#endregion

#region usings

using System;
using TikzAutomata.TikzFigure.Base;
using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure.Nodes
{
  public sealed class FigureNode : FigureObjectBase, INode
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
  }
}