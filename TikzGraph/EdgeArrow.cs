#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: EdgeArrow.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-03 8:45 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutonoma
{
  [Flags]
  public enum EdgeArrow : byte
  {
    None = 0,
    Left = 1 << 0,
    Right = 1 << 1,
    Both = 1 << 2
  }
}