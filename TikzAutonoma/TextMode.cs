#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: TextMode.cs
// 
// Current Data:
// 2021-05-11 5:13 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

namespace TikzAutonoma
{
  /// <summary>
  ///   Enum to indicate whether labels should be rendered as plain text or as a meth environment
  /// </summary>
  public enum TextMode
  {
    /// <summary>
    ///   Indicates plain text
    /// </summary>
    PlainText,

    /// <summary>
    ///   Indicates a math environment
    /// </summary>
    MathText
  }
}