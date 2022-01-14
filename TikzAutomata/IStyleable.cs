#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IStyleable.cs
// 
// Current Data:
// 2022-01-14 9:04 PM
// 
// Creation Date:
// 2022-01-14 9:03 PM

#endregion

namespace TikzAutomata
{
  public interface IStyleable
  {
    void ApplyStyle(string styleName);
    void ApplyStyle(IStyle style);
  }
}