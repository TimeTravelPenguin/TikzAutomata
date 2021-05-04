#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: ITikzEdge.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

namespace TikzGraph.TikzObjects
{
  public interface ITikzEdge : ITikzObject, ITikzWritable
  {
    Direction TextDirection { get; set; }
  }
}