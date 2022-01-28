namespace TikzAutomata.Encoders
{
  internal class TikzEdgeTag : IScriptBuilderComponent
  {
    private readonly string _edgeOpts;
    private readonly string _idFrom;
    private readonly string _idTo;
    private readonly string _nodeOpts;
    private readonly string _text;

    public string RenderTag(int tab)
    {
      var tabStr = new string(' ', tab);

      return $"{tabStr}\\draw ({_idFrom}) edge[{_edgeOpts}] node[{_nodeOpts}] {{{_text}}} ({_idTo});";
    }

    public TikzEdgeTag(string idFrom, string idTo, string edgeOpts, string nodeOpts, string text)
    {
      _idFrom = idFrom;
      _idTo = idTo;
      _edgeOpts = edgeOpts;
      _nodeOpts = nodeOpts;
      _text = text;
    }
  }
}