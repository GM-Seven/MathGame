using System.Security.Cryptography;
using MathGame;

Console.WriteLine("Welcom to the Math Game!");
var name = Helpers.GetName();
var games = new List<string>();
var menu = new Menu();

menu.ShowMenu(name);


