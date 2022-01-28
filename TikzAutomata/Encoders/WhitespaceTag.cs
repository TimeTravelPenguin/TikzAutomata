namespace TikzAutomata.Encoders
{
  internal class WhitespaceTag : IScriptBuilderComponent
  {
    #region Implementation of IScriptBuilderComponent

    public string RenderTag(int tab)
    {
      return string.Empty;
    }

    #endregion
  }
}