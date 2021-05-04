#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: EdgeArrow.cs
// 
// Current Data:
// 2021-05-03 8:45 PM
// 
// Creation Date:
// 2021-05-03 8:45 PM

#endregion

#region usings

using System;

#endregion

namespace TikzGraph
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