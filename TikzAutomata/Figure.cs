#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: Figure.cs
// 
// Current Data:
// 2022-01-14 9:29 PM
// 
// Creation Date:
// 2022-01-14 9:03 PM

#endregion

#region usings

#endregion

#region usings

using System.Collections.Generic;

#endregion

namespace TikzAutomata
{
  public class Figure : IFigureObject
  {
    private readonly List<IFigureObject> _figureNodes = new();

    public string Id { get; }

    public string Text { get; set; }

    public Figure(string id, string text)
    {
      Id = id;
      Text = text;
    }

    public void AddNode(FigureNode node)
    {
      _figureNodes.Add(node);
    }
  }
}