#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: ITikzNode.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

#region usings

#endregion

namespace TikzGraph.TikzObjects
{
  public interface ITikzNode : ITikzObject, ITikzWritable
  {
    bool IsInitialNode { get; set; }
  }
}