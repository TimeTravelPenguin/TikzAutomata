#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: ITikzObject.cs
// 
// Current Data:
// 2021-05-11 5:02 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   Interface encapsulating Tikz objects
  /// </summary>
  public interface ITikzObject
  {
    /// <summary>
    ///   The name used to reference this node in the Tikz figure
    /// </summary>
    string Name { get; set; }

    /// <summary>
    ///   The text present shown within this object
    /// </summary>
    string Label { get; set; }

    /// <summary>
    ///   Indicates whether or not to enclose the compiled label in $ $
    /// </summary>
    TextMode TextMode { get; set; }

    /// <summary>
    ///   Shift the label text along the x-axis
    /// </summary>
    double XShift { get; set; }

    /// <summary>
    ///   Shift the label text along the y-axis
    /// </summary>
    double YShift { get; set; }
  }
}