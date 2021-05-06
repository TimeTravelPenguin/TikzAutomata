#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: ITikzNode.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

#region usings

#endregion

namespace TikzAutonoma.TikzObjects
{
  public interface ITikzNode : ITikzObject, ITikzWritable
  {
    bool IsInitialNode { get; set; }
  }
}