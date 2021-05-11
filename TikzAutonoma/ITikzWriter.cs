#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: ITikzWriter.cs
// 
// Current Data:
// 2021-05-11 5:12 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

using TikzAutonoma.TikzObjects;

#endregion

namespace TikzAutonoma
{
  /// <summary>
  ///   Interface for object able to compile <see cref="ITikzWritable" /> objects
  /// </summary>
  public interface ITikzWriter
  {
    /// <summary>
    ///   Compiles a node to Tikz format
    /// </summary>
    /// <param name="node">The node to compile</param>
    /// <returns>Returns the current node as a string in Tikz format</returns>
    string CompileNode(ITikzNode node);

    /// <summary>
    ///   Compiles a edge to Tikz format
    /// </summary>
    /// <param name="edge">The edge to compile</param>
    /// <returns>Returns the current edge as a string in Tikz format</returns>
    string CompileEdge(ITikzEdge edge);

    /// <summary>
    ///   Compiles node definitions in an associative format for Tikz figures
    /// </summary>
    /// <param name="nodeAssociation">The association between two nodes</param>
    /// <returns>Returns the current node association in Tikz format</returns>
    string FormatNodeAssociation(NodeAssociation nodeAssociation);

    /// <summary>
    ///   Compiles edge definitions in an associative format for Tikz figures
    /// </summary>
    /// <param name="edgeAssociation">The association between two nodes</param>
    /// <returns>Returns the current edge association in Tikz format</returns>
    string FormatEdgeAssociation(EdgeAssociation edgeAssociation);
  }
}