using System.Collections.Generic;
using TikzAutomata.TikzFigure.Edges;
using TikzAutomata.TikzFigure.Nodes;

namespace TikzAutomata.Encoders
{
  internal class ScriptBuilder
  {
    private readonly IEnumerable<IEdge> _edges;
    private readonly IEnumerable<INode> _nodes;

    public ScriptBuilder(IEnumerable<INode> nodes, IEnumerable<IEdge> edges)
    {
      _nodes = nodes;
      _edges = edges;
    }

    public string Build()
    {
      var tkPicture = new ScriptEnvironment("tikzpicture");

      foreach (var node in _nodes)
      {
        tkPicture.EnvironmentBody.Add(new TikzNodeTag(node.Id, "", node.Text));
      }

      tkPicture.EnvironmentBody.Add(new WhitespaceTag());

      foreach (var edge in _edges)
      {
        tkPicture.EnvironmentBody.Add(new TikzEdgeTag(edge.NodeTail.Id, edge.NodeTip.Id, "", "", edge.Text));
      }

      return tkPicture.RenderTag(0);
    }
  }
}