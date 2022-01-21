#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IEdge.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:23 PM

#endregion

namespace TikzAutomata.TikzFigure
{
  public interface IEdge : IFigureObject, IStyleable
  {
    INode NodeTip { get; set; }
    INode NodeTail { get; set; }
  }
}