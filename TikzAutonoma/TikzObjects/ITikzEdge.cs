﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: ITikzEdge.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-04 5:34 PM

#endregion

namespace TikzAutonoma.TikzObjects
{
  public interface ITikzEdge : ITikzObject, ITikzWritable
  {
    Direction TextDirection { get; set; }
  }
}