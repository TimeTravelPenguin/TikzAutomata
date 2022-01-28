namespace TikzAutomata.Encoders
{
  internal class TikzNodeTag : IScriptBuilderComponent
  {
    private readonly string _id;
    private readonly string _opts;
    private readonly string _text;

    public string RenderTag(int tab)
    {
      var tabStr = new string(' ', tab);

      return $"{tabStr}\\node[{_opts}] ({_id}) {{{_text}}};";
    }

    public TikzNodeTag(string id, string opts, string text)
    {
      _id = id;
      _opts = opts;
      _text = text;
    }
  }
}