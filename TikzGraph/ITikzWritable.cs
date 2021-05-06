#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzAutonoma
// File Name: ITikzWritable.cs
// 
// Current Data:
// 2021-05-06 9:17 PM
// 
// Creation Date:
// 2021-05-03 8:45 PM

#endregion

#region usings

#endregion

namespace TikzAutonoma
{
  public interface ITikzWritable
  {
    string Compile(ITikzWriter writer);
  }
}