#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureObjectBase.cs
// 
// Current Data:
// 2022-01-21 11:48 PM
// 
// Creation Date:
// 2022-01-21 11:30 PM

#endregion

#region usings

#endregion

namespace TikzAutomata.TikzFigure
{
  public abstract class FigureObjectBase : IFigureObject, IStyleable
  {
    public string Id { get; protected set; }

    public string Text { get; set; }

    public abstract void ApplyStyle(string styleName);

    public abstract void ApplyStyle(IStyle style);
  }
}