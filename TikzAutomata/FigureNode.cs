#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureNode.cs
// 
// Current Data:
// 2022-01-14 9:26 PM
// 
// Creation Date:
// 2022-01-14 8:07 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutomata
{
  public class FigureNode : IFigureObject, IStyleable
  {
    public string Id { get; }

    public string Text { get; set; }

    public void ApplyStyle(string styleName)
    {
      throw new NotImplementedException();
    }

    public void ApplyStyle(IStyle style)
    {
      throw new NotImplementedException();
    }

    public FigureNode(string id, string text)
    {
      Id = id;
      Text = text;
    }
  }
}