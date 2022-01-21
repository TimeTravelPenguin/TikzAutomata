#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: INode.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:06 AM

#endregion

#region usings

using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure.Nodes
{
  public interface INode : IFigureObject, IStyleable
  {
  }
}