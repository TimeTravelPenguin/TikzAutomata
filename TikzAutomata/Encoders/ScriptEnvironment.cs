using System.Collections.Generic;
using System.Text;

namespace TikzAutomata.Encoders
{
  internal class ScriptEnvironment : IScriptBuilderComponent
  {
    private readonly string _envName;
    public List<IScriptBuilderComponent> EnvironmentBody { get; } = new();

    public string RenderTag(int tab)
    {
      var tabStr = new string(' ', tab);
      var sb = new StringBuilder();

      sb.AppendLine($"{tabStr}\\begin{{{_envName}}}");

      foreach (var component in EnvironmentBody)
      {
        sb.AppendLine(component.RenderTag(tab + 2));
      }

      sb.AppendLine($"{tabStr}\\end{{{_envName}}}");
      return sb.ToString();
    }

    public ScriptEnvironment(string envName)
    {
      _envName = envName;
    }
  }
}