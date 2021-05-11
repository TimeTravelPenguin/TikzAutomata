#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: ITikzEdge.cs
// 
// Current Data:
// 2021-05-11 4:24 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   Interface encapsulating the Tikz Edge objects
  /// </summary>
  public interface ITikzEdge : ITikzObject, ITikzWritable
  {
    Direction TextDirection { get; set; }
  }
}