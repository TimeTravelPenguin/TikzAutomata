#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: TikzExporter.cs
// 
// Current Data:
// 2021-05-04 5:35 PM
// 
// Creation Date:
// 2021-05-04 5:32 PM

#endregion

#region usings

using System;
using TikzGraph.TikzObjects;

#endregion

namespace TikzGraph
{
  internal class TikzExporter : ITikzWriter
  {
    public string CompileNode(ITikzNode node)
    {
      if (node is null)
      {
        throw new ArgumentNullException(nameof(node));
      }

      var isInstance = node.IsInitialNode ? ", initial" : string.Empty;

      var xShift = node.XShift != 0 ? $", xshift={node.XShift}mm" : string.Empty;
      var yShift = node.YShift != 0 ? $", yshift={node.YShift}mm" : string.Empty;
      var shift = xShift + yShift;

      var label = node.TextMode == TextMode.MathText ? @$" {{${node.Label}$}}" : @$" {{{node.Label}}}";
      label = node.Label == string.Empty ? string.Empty : label;

      return @$"\node[state{isInstance}{shift}[0]] ({node.Name}){label};";
    }

    public string CompileEdge(ITikzEdge edge)
    {
      if (edge is null)
      {
        throw new ArgumentNullException(nameof(edge));
      }

      var xShift = edge.XShift != 0 ? $", xshift={edge.XShift}mm" : string.Empty;
      var yShift = edge.YShift != 0 ? $", yshift={edge.YShift}mm" : string.Empty;
      var shift = $"[{xShift + yShift}]";

      var label = edge.TextMode == TextMode.MathText ? @$" {{${edge.Label}$}}" : @$" {{{edge.Label}}}";
      label = edge.Label == string.Empty ? string.Empty : label;

      return @$"([0]) edge{shift}{label} ([1])";
    }

    public string FormatNodeAssociation(NodeAssociation nodeAssociation)
    {
      var source = nodeAssociation.SourceNode;
      var target = nodeAssociation.TargetNode;
      var direction = nodeAssociation.AssociationDirection;
      var compiled = source.Compile(this);

      var directionArg = direction == Direction.None && source == target
        ? string.Empty
        : $", {direction} of={target.Name}";

      return compiled.Replace("[0]", directionArg);
    }

    public string FormatEdgeAssociation(EdgeAssociation edgeAssociation)
    {
      var source = edgeAssociation.SourceNode;
      var target = edgeAssociation.TargetNode;
      var compiled = edgeAssociation.Edge.Compile(this);

      return compiled.Replace("[0]", source.Name)
        .Replace("[1]", target.Name);
    }
  }
}