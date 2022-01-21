#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureObjectBase.cs
// 
// Current Data:
// 2022-01-22 12:06 AM
// 
// Creation Date:
// 2022-01-22 12:04 AM

#endregion

#region usings

#endregion

#region usings

using TikzAutomata.TikzFigure.Styles;

#endregion

namespace TikzAutomata.TikzFigure.Base
{
  public abstract class FigureObjectBase : IFigureObject, IStyleable
  {
    public string Id { get; protected set; }

    public string Text { get; set; }

    public abstract void ApplyStyle(string styleName);

    public abstract void ApplyStyle(IStyle style);
  }
}