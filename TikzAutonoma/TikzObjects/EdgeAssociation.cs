#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: EdgeAssociation.cs
// 
// Current Data:
// 2021-05-11 4:29 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   A record object used to associate an edge to a pair of nodes
  /// </summary>
  public record EdgeAssociation
  {
    /// <summary>
    ///   The edge object of the node-edge-node association
    /// </summary>
    public ITikzEdge Edge { get; init; }

    /// <summary>
    ///   The source node of the node-edge-node association
    /// </summary>
    public ITikzNode SourceNode { get; init; }

    /// <summary>
    ///   The target node of the node-edge-node association
    /// </summary>
    public ITikzNode TargetNode { get; init; }

    /// <summary>
    ///   Constructs a new node-edge-node association
    /// </summary>
    /// <param name="edge">The edge object of the association</param>
    /// <param name="sourceNode">The source node of the association</param>
    /// <param name="targetNode">The target node of the association</param>
    public EdgeAssociation(ITikzEdge edge, ITikzNode sourceNode, ITikzNode targetNode)
    {
      Edge = edge ?? throw new ArgumentNullException(nameof(edge));
      SourceNode = sourceNode ?? throw new ArgumentNullException(nameof(sourceNode));
      TargetNode = targetNode ?? throw new ArgumentNullException(nameof(targetNode));
    }
  }
}