#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: ITikzWriter.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 9:21 AM

#endregion

#region usings

using TikzAutonoma.TikzObjects;

#endregion

namespace TikzAutonoma
{
  public interface ITikzWriter
  {
    string CompileNode(ITikzNode node);
    string CompileEdge(ITikzEdge node);
    string FormatNodeAssociation(NodeAssociation nodeAssociation);
    string FormatEdgeAssociation(EdgeAssociation edgeAssociation);
  }
}