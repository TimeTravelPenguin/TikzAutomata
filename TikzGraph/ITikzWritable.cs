#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzGraph
// Project: TikzGraph
// File Name: ITikzWritable.cs
// 
// Current Data:
// 2021-05-04 10:06 AM
// 
// Creation Date:
// 2021-05-03 8:45 PM

#endregion

#region usings

#endregion

namespace TikzGraph
{
  public interface ITikzWritable
  {
    string Compile(ITikzWriter writer);
  }
}