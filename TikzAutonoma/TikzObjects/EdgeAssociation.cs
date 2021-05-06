#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: EdgeAssociation.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutonoma.TikzObjects
{
  public record EdgeAssociation
  {
    public ITikzEdge Edge { get; init; }
    public ITikzNode SourceNode { get; init; }
    public ITikzNode TargetNode { get; init; }

    public EdgeAssociation(ITikzEdge edge, ITikzNode sourceNode, ITikzNode targetNode)
    {
      Edge = edge ?? throw new ArgumentNullException(nameof(edge));
      SourceNode = sourceNode ?? throw new ArgumentNullException(nameof(sourceNode));
      TargetNode = targetNode ?? throw new ArgumentNullException(nameof(targetNode));
    }
  }
}