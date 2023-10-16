// See https://aka.ms/new-console-template for more information
using Builder;
Console.Title = "Builder Pattern";

Casher casher = new Casher();

IBurgerBuilder Wburger = new WorldWarBurger();
IBurgerBuilder Oburger = new OriginalBurger();

casher.Constract(Wburger);
Console.WriteLine(Wburger._burger.ToString());
