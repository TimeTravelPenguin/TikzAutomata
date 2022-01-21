#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: IFigureEncoder.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:21 PM

#endregion

#region usings

using TikzAutomata.TikzFigure;

#endregion

namespace TikzAutomata.Encoders
{
  public interface IFigureEncoder
  {
    string Encode(IFigure encodeable);
  }
}