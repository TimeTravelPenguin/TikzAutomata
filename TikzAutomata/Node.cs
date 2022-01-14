#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata
// File Name: Node.cs
// 
// Current Data:
// 2022-01-14 8:01 PM
// 
// Creation Date:
// 2022-01-14 7:57 PM

#endregion

#region usings

using System;

#endregion

namespace TikzAutomata
{
  public interface ITikzObject
  {
    string ToTikzString();
  }

  public sealed class Node : ITikzObject
  {
    public string ToTikzString()
    {
      throw new NotImplementedException();
    }
  }
}