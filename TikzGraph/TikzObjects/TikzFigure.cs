#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: TikzFigure.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

#region usings

using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzAutonoma.Properties;

#endregion

namespace TikzAutonoma.TikzObjects
{
  public class TikzFigure
  {
    private static readonly ITikzWriter TikzWriter = new TikzExporter();
    private readonly IList<EdgeAssociation> _edgeAssociations = new List<EdgeAssociation>();
    private readonly IList<NodeAssociation> _nodeAssociations = new List<NodeAssociation>();
    public string Caption { get; set; }
    public string Label { get; set; }

    public TikzFigure(string caption, string label, ITikzNode rootNode)
    {
      Caption = caption;
      Label = label;

      _nodeAssociations.Add(new NodeAssociation(rootNode, rootNode, Direction.None));
    }

    public void AddEdge(ITikzEdge edge, ITikzNode source, ITikzNode target)
    {
      _edgeAssociations.Add(new EdgeAssociation(edge, source, target));
    }

    public void AddNode(ITikzNode source, ITikzNode target, Direction direction)
    {
      _nodeAssociations.Add(new NodeAssociation(source, target, direction));
    }

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