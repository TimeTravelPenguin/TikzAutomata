﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: NodeAssociation.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

#region usings

using System;

#endregion

namespace TikzGraph.TikzObjects
{
  public record NodeAssociation
  {
    public ITikzNode SourceNode { get; init; }
    public ITikzNode TargetNode { get; init; }
    public Direction AssociationDirection { get; init; }

    public NodeAssociation(ITikzNode sourceNode, ITikzNode targetNode, Direction associationDirection)
    {
      SourceNode = sourceNode ?? throw new ArgumentNullException(nameof(sourceNode));
      TargetNode = targetNode ?? throw new ArgumentNullException(nameof(targetNode));
      AssociationDirection = associationDirection;
    }
  }
}