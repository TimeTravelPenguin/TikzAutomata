#region Title Header

// Name: Phillip Smith
// 
// Solution: TikzAutomata
// Project: TikzAutomata.Scratch
// File Name: Program.cs
// 
// Current Data:
// 2022-01-28 11:29 PM
// 
// Creation Date:
// 2022-01-28 11:25 PM

#endregion

#region usings

using TikzAutomata.Encoders;
using TikzAutomata.TikzFigure;
using TikzAutomata.TikzFigure.Edges;
using TikzAutomata.TikzFigure.Nodes;

#endregion

var figure = new Figure();

var n1 = new FigureNode("n1", "First");
var n2 = new FigureNode("n2", "Second");
var n3 = new FigureNode("n3", "Third");

figure.AddNode(n1);
figure.AddNode(n2);
figure.AddNode(n3);

var e12 = new FigureEdge("e12", "", n2, n1);
var e23 = new FigureEdge("e23", "", n3, n2);
var e31 = new FigureEdge("e31", "", n1, n3, bendDirection: Bend.Left);

figure.AddEdge(e12);
figure.AddEdge(e23);
figure.AddEdge(e31);

var encoder = new FigureEncoder(figure);
var figOut = encoder.Encode();

Console.WriteLine(figOut);
Console.ReadKey(true);