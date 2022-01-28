#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: FigureEncoder.cs
// 
// Current Data:
// 2022-01-28 11:24 PM
// 
// Creation Date:
// 2022-01-28 10:26 PM

#endregion

#region usings

using TikzAutomata.TikzFigure;

#endregion

namespace TikzAutomata.Encoders
{
  public class FigureEncoder : IFigureEncoder
  {
    private readonly IFigure _figure;

    #region Implementation of IFigureEncoder

    public string Encode()
    {
      var builder = new ScriptBuilder(_figure.GetNodes(), _figure.GetEdges());
      return builder.Build();
    }

    #endregion

    public FigureEncoder(IFigure figure)
    {
      _figure = figure;
    }
  }
}