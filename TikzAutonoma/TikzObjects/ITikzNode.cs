#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: ITikzNode.cs
// 
// Current Data:
// 2021-05-11 4:24 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   Interface encapsulating the Tikz Node objects
  /// </summary>
  public interface ITikzNode : ITikzObject, ITikzWritable
  {
    bool IsInitialNode { get; set; }
  }
}