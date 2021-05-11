#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TikzNode.cs
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
  ///   A node object for a Tikz figure
  /// </summary>
  public class TikzNode : TikzObject, ITikzNode
  {
    /// <summary>
    ///   Indicates that this node is an initial node in figure and adds an arrow
    ///   to indicate the figure entry point
    /// </summary>
    public bool IsInitialNode { get; set; }

    /// <summary>
    ///   Compiles the node to a Tikz format
    /// </summary>
    /// <param name="writer">The writer used to compile this object</param>
    /// <returns>Returns the current node as a string in Tikz format</returns>
    public override string Compile(ITikzWriter writer)
    {
      return writer.CompileNode(this);
    }

    /// <summary>
    ///   Constructs a new node
    /// </summary>
    /// <param name="name">The name used to reference this node in the Tikz figure</param>
    /// <param name="label">The text present shown within this node</param>
    /// <param name="textMode">Indicates whether or not to enclose the compiled label in $ $</param>
    /// <param name="xShift">Shift the label text along the x-axis</param>
    /// <param name="yShift">Shift the label text along the y-axis</param>
    /// <param name="isInitialNode">
    ///   Indicates that this node is an initial node in figure and adds an arrow
    ///   to indicate the figure entry point
    /// </param>
    public TikzNode(string name, string label, TextMode textMode = TextMode.MathText,
      double xShift = 0, double yShift = 0, bool isInitialNode = false)
      : base(name, label, textMode, xShift, yShift)
    {
      IsInitialNode = isInitialNode;
    }
  }
}