#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TikzObject.cs
// 
// Current Data:
// 2021-05-11 5:03 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   Base class used for all Tikz objects
  /// </summary>
  public abstract class TikzObject : ITikzWritable, ITikzObject
  {
    /// <summary>
    ///   The text present shown within this object
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    ///   The name used to reference this node in the Tikz figure
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///   Indicates whether or not to enclose the compiled label in $ $
    /// </summary>
    public TextMode TextMode { get; set; }

    /// <summary>
    ///   Shift the label text along the x-axis
    /// </summary>
    public double XShift { get; set; }

    /// <summary>
    ///   Shift the label text along the y-axis
    /// </summary>
    public double YShift { get; set; }

    /// <summary>
    ///   Compiles the object to a Tikz format
    /// </summary>
    /// <param name="writer">The writer used to compile this object</param>
    /// <returns>Returns the current node as a string in Tikz format</returns>
    public abstract string Compile(ITikzWriter writer);

    /// <summary>
    ///   Base constructor used for making new Tikz objects
    /// </summary>
    /// <param name="name">The name used to reference this node in the Tikz figure</param>
    /// <param name="label">The text present shown within this object</param>
    /// <param name="textMode">Indicates whether or not to enclose the compiled label in $ $</param>
    /// <param name="xShift">Shift the label text along the x-axis</param>
    /// <param name="yShift">Shift the label text along the y-axis</param>
    protected TikzObject(string name, string label, TextMode textMode, double xShift, double yShift)
    {
      Name = name;
      Label = label;
      TextMode = textMode;
      XShift = xShift;
      YShift = yShift;
    }
  }
}