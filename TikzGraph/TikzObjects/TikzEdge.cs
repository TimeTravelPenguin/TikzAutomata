#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: TikzEdge.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

namespace TikzAutonoma.TikzObjects
{
  public class TikzEdge : TikzObject, ITikzEdge
  {
    public Direction TextDirection { get; set; }

    public override string Compile(ITikzWriter writer)
    {
      return writer.CompileEdge(this);
    }

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