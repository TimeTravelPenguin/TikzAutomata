#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TikzWriter.cs
// 
// Current Data:
// 2021-05-11 5:17 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

using System;
using System.Linq;
using TikzAutonoma.TikzObjects;

#endregion

namespace TikzAutonoma
{
  /// <summary>
  ///   Writer object used to compile objects to Tikz format
  /// </summary>
  public class TikzWriter : ITikzWriter
  {
    /// <summary>
    ///   Compiles a node to Tikz format
    /// </summary>
    /// <param name="node">The node to compile</param>
    /// <returns>Returns the current node as a string in Tikz format</returns>
    public string CompileNode(ITikzNode node)
    {
      if (node is null)
      {
        throw new ArgumentNullException(nameof(node));
      }

      var isInstance = node.IsInitialNode ? "initial" : string.Empty;
      var xShift = node.XShift != 0 ? $"xshift={node.XShift}mm" : string.Empty;
      var yShift = node.YShift != 0 ? $"yshift={node.YShift}mm" : string.Empty;

      var nodeArgs = new[] {"state", isInstance, xShift, yShift}.Where(x => !string.IsNullOrWhiteSpace(x));

      var label = node.TextMode == TextMode.MathText ? @$" {{${node.Label}$}}" : @$" {{{node.Label}}}";
      label = node.Label == string.Empty ? string.Empty : label;

      return @$"\node[{string.Join(", ", nodeArgs)}[0]] ({node.Name}){label};";
    }

    /// <summary>
    ///   Compiles a edge to Tikz format
    /// </summary>
    /// <param name="edge">The edge to compile</param>
    /// <returns>Returns the current edge as a string in Tikz format</returns>
    public string CompileEdge(ITikzEdge edge)
    {
      if (edge is null)
      {
        throw new ArgumentNullException(nameof(edge));
      }

      var textDirection = edge.TextDirection == Direction.None
        ? string.Empty
        : edge.TextDirection.ToString().ToLowerInvariant();
      var edgeArgs = new[] {textDirection}.Where(x => !string.IsNullOrWhiteSpace(x));

      var label = edge.TextMode == TextMode.MathText ? @$" {{${edge.Label}$}}" : @$" {{{edge.Label}}}";
      label = edge.Label == string.Empty ? string.Empty : label;

      var xShift = edge.XShift != 0 ? $"xshift={edge.XShift}mm" : string.Empty;
      var yShift = edge.YShift != 0 ? $"yshift={edge.YShift}mm" : string.Empty;

      var nodeArgs = new[] {xShift, yShift}.Where(x => !string.IsNullOrWhiteSpace(x));
      var node = $" node[{string.Join(", ", nodeArgs)}]";


      return @$"([0]) edge[{string.Join(", ", edgeArgs)}]{node}{label} ([1])";
    }

    /// <summary>
    ///   Compiles node definitions in an associative format for Tikz figures
    /// </summary>
    /// <param name="nodeAssociation">The association between two nodes</param>
    /// <returns>Returns the current node association in Tikz format</returns>
    public string FormatNodeAssociation(NodeAssociation nodeAssociation)
    {
      var source = nodeAssociation.SourceNode;
      var target = nodeAssociation.TargetNode;
      var direction = nodeAssociation.AssociationDirection;
      var compiled = source.Compile(this);

      var directionArg = direction == Direction.None && source == target
        ? string.Empty
        : $", {direction.ToString().ToLowerInvariant()} of={target.Name}";

      return compiled.Replace("[0]", directionArg);
    }

    /// <summary>
    ///   Compiles edge definitions in an associative format for Tikz figures
    /// </summary>
    /// <param name="edgeAssociation">The association between two nodes</param>
    /// <returns>Returns the current edge association in Tikz format</returns>
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