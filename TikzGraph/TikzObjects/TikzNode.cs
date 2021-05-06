#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: TikzNode.cs
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
  public class TikzNode : TikzObject, ITikzNode
  {
    public bool IsInitialNode { get; set; }

    public override string Compile(ITikzWriter writer)
    {
      return writer.CompileNode(this);
    }

    public TikzNode(string name, string label, TextMode textMode = TextMode.MathText,
      double xShift = 0, double yShift = 0, bool isInitialNode = false)
      : base(name, label, textMode, xShift, yShift)
    {
      IsInitialNode = isInitialNode;
    }
  }
}