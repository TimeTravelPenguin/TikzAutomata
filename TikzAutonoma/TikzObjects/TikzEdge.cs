#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TikzEdge.cs
// 
// Current Data:
// 2021-05-11 4:54 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   An edge object for a Tikz figure
  /// </summary>
  public class TikzEdge : TikzObject, ITikzEdge
  {
    /// <summary>
    ///   The location of the text relative to direction of the edge
    /// </summary>
    public Direction TextDirection { get; set; }

    /// <summary>
    ///   Compiles the edge to a Tikz format
    /// </summary>
    /// <param name="writer">The writer used to compile this object</param>
    /// <returns>Returns the current edge as a string in Tikz format</returns>
    public override string Compile(ITikzWriter writer)
    {
      return writer.CompileEdge(this);
    }

    /// <summary>
    ///   Constructs a new Edge
    /// </summary>
    /// <param name="label">The text shown along the edge</param>
    /// <param name="textMode">Indicates whether or not to enclose the compiled label in $ $</param>
    /// <param name="textDirection">The location of the text relative to direction of the edge</param>
    /// <param name="xShift">Shift the label text along the x-axis</param>
    /// <param name="yShift">Shift the label text along the y-axis</param>
    public TikzEdge(string label, TextMode textMode = TextMode.MathText,
      Direction textDirection = Direction.Above,
      double xShift = 0, double yShift = 0)
      : base("", label, textMode, xShift, yShift)
    {
      TextDirection = textDirection;
      XShift = xShift;
      YShift = yShift;
    }
  }
}