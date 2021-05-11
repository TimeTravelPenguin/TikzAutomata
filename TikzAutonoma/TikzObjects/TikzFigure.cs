#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TikzFigure.cs
// 
// Current Data:
// 2021-05-11 5:14 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzAutonoma.Properties;

#endregion

namespace TikzAutonoma.TikzObjects
{
  /// <summary>
  ///   The object encapsulating a TikzFigure
  /// </summary>
  public class TikzFigure
  {
    private static readonly ITikzWriter TikzWriter = new TikzWriter();
    private readonly IList<EdgeAssociation> _edgeAssociations = new List<EdgeAssociation>();
    private readonly IList<NodeAssociation> _nodeAssociations = new List<NodeAssociation>();

    /// <summary>
    ///   LaTeX figure caption text
    /// </summary>
    public string Caption { get; set; }

    /// <summary>
    ///   LaTeX figure label/name
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    ///   Constructs a new Tikz figure
    /// </summary>
    /// <param name="caption">LaTeX figure caption text</param>
    /// <param name="label">LaTeX figure label/name</param>
    /// <param name="rootNode">The initial node used in the figure</param>
    public TikzFigure(string caption, string label, ITikzNode rootNode)
    {
      Caption = caption;
      Label = label;

      _nodeAssociations.Add(new NodeAssociation(rootNode, rootNode, Direction.None));
    }

    /// <summary>
    ///   Adds a new edge associated with a source and target node
    /// </summary>
    /// <param name="edge">The edge object</param>
    /// <param name="source">The source node</param>
    /// <param name="target">The target node</param>
    public void AddEdge(ITikzEdge edge, ITikzNode source, ITikzNode target)
    {
      _edgeAssociations.Add(new EdgeAssociation(edge, source, target));
    }

    /// <summary>
    ///   Adds a new node association with another node
    /// </summary>
    /// <param name="source">The source node</param>
    /// <param name="target">The target node</param>
    /// <param name="direction">The direction of <paramref name="target" /> relative to <paramref name="source" /></param>
    public void AddNode(ITikzNode source, ITikzNode target, Direction direction)
    {
      _nodeAssociations.Add(new NodeAssociation(source, target, direction));
    }

    /// <summary>
    ///   Compiles the figure to a Tikz format
    /// </summary>
    /// <returns>Returns the current figure as a string in Tikz format</returns>
    public string Build()
    {
      var sb = new StringBuilder();
      var ind = new string(' ', 8);

      foreach (var nodeAssociation in _nodeAssociations)
      {
        sb.Append(ind + TikzWriter.FormatNodeAssociation(nodeAssociation));
        sb.AppendLine();
      }

      sb.AppendLine();

      if (_edgeAssociations.Count > 0)
      {
        sb.Append(@$"{ind}\draw " + TikzWriter.FormatEdgeAssociation(_edgeAssociations.First()));
        sb.AppendLine();
      }

      ind = new string(' ', 14);
      foreach (var edgeAssociation in _edgeAssociations.Skip(1))
      {
        sb.Append(ind + TikzWriter.FormatEdgeAssociation(edgeAssociation));
        sb.AppendLine();
      }

      ind = new string(' ', 8);
      sb.Append(ind + ";");

      return Resources.TikzCodeTemplate
        .Replace("{0}", sb.ToString())
        .Replace("{1}", Caption)
        .Replace("{2}", Label);
    }
  }
}