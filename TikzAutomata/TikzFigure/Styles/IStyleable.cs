#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IStyleable.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:04 AM

#endregion

namespace TikzAutomata.TikzFigure.Styles
{
  public interface IStyleable
  {
    void ApplyStyle(string styleName);
    void ApplyStyle(IStyle style);
  }
}