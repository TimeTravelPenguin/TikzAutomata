#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IEdge.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:05 AM

#endregion

#region usings

using TikzAutomata.TikzFigure.Nodes;
using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure.Edges
{
  public interface IEdge : IFigureObject, IStyleable
  {
    INode NodeTip { get; set; }
    INode NodeTail { get; set; }
    Bend BendDirection { get; set; }
  }
}