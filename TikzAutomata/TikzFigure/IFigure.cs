#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IFigure.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:09 PM

#endregion

namespace TikzAutomata.TikzFigure
{
  public interface IFigure
  {
    void AddNode(INode node);
    void AddEdge(IEdge edge);
  }
}