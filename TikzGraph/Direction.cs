#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: Direction.cs
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
  public enum Direction : byte
  {
    None = 0,
    Above = 1 << 0,
    Below = 1 << 1,
    Left = 1 << 2,
    Right = 1 << 3
  }
}