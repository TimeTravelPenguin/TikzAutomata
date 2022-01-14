#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IFigureObject.cs
// 
// Current Data:
// 2022-01-14 9:04 PM
// 
// Creation Date:
// 2022-01-14 9:03 PM

#endregion

namespace TikzAutomata
{
  public interface IFigureObject
  {
    string Id { get; }
    string Text { get; set; }
  }
}