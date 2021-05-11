#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: NodeAssociation.cs
// 
// Current Data:
// 2021-05-11 4:30 PM
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
  ///   A record object used to associate a pair of adjacent edges.
  /// </summary>
  public record NodeAssociation
  {
    /// <summary>
    ///   The source node of the association
    /// </summary>
    public ITikzNode SourceNode { get; init; }

    /// <summary>
    ///   The target node of the association
    /// </summary>
    public ITikzNode TargetNode { get; init; }

    /// <summary>
    ///   The direction of <see cref="TargetNode" /> relative to <see cref="SourceNode" />.
    /// </summary>
    public Direction AssociationDirection { get; init; }

    /// <summary>
    ///   Constructs a new node-node association
    /// </summary>
    /// <param name="sourceNode">The source node of the association</param>
    /// <param name="targetNode">The target node of the association</param>
    /// <param name="associationDirection">
    ///   The direction in which <paramref name="targetNode" />
    ///   is to <paramref name="sourceNode" />
    /// </param>
    public NodeAssociation(ITikzNode sourceNode, ITikzNode targetNode, Direction associationDirection)
    {
      SourceNode = sourceNode ?? throw new ArgumentNullException(nameof(sourceNode));
      TargetNode = targetNode ?? throw new ArgumentNullException(nameof(targetNode));
      AssociationDirection = associationDirection;
    }
  }
}