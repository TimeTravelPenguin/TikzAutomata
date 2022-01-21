#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IFigureObject.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-21 11:21 PM

#endregion

namespace TikzAutomata.TikzFigure
{
  public interface IFigureObject
  {
    string Id { get; }
    string Text { get; set; }
  }
}