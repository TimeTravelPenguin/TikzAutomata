#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: ITikzWriter.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 9:21 AM

#endregion

#region usings

using TikzGraph.TikzObjects;

#endregion

namespace TikzGraph
{
  public interface ITikzWriter
  {
    string CompileNode(ITikzNode node);
    string CompileEdge(ITikzEdge node);
    string FormatNodeAssociation(NodeAssociation nodeAssociation);
    string FormatEdgeAssociation(EdgeAssociation edgeAssociation);
  }
}