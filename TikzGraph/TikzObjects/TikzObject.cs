#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: TikzObject.cs
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
  public abstract class TikzObject : ITikzWritable, ITikzObject
  {
    public string Label { get; set; }
    public string Name { get; set; }
    public TextMode TextMode { get; set; }
    public double XShift { get; set; }
    public double YShift { get; set; }

    public abstract string Compile(ITikzWriter writer);

    /// <summary>
    ///   A wrapper object used for making TikzFigure objects
    /// </summary>
    /// <param name="label">The text shown by the object</param>
    /// <param name="name">The name of the object in the TikzFigure code</param>
    /// <param name="textMode">Whether or not to wrap text in $$ to indicate math mode</param>
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