#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: ITikzObject.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

namespace TikzGraph.TikzObjects
{
  public interface ITikzObject
  {
    string Name { get; set; }
    string Label { get; set; }
    TextMode TextMode { get; set; }
    double XShift { get; set; }
    double YShift { get; set; }
  }
}