#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IStyleable.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:21 PM

#endregion

namespace TikzAutomata.TikzFigure
{
  public interface IStyleable
  {
    void ApplyStyle(string styleName);
    void ApplyStyle(IStyle style);
  }
}