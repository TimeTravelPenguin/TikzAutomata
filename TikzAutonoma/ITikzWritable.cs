#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutonoma
// Project: TikzAutonoma
// File Name: ITikzWritable.cs
// 
// Current Data:
// 2021-05-11 5:04 PM
// 
// Creation Date:
// 2021-05-07 3:23 PM

#endregion

#region usings

#endregion

namespace TikzAutonoma
{
  /// <summary>
  ///   Interface for objects compilable for Tikz
  /// </summary>
  public interface ITikzWritable
  {
    /// <summary>
    ///   Compiles the object to a Tikz format
    /// </summary>
    /// <param name="writer">The writer used to compile this object</param>
    /// <returns>Returns the current object as a string in Tikz format</returns>
    string Compile(ITikzWriter writer);
  }
}