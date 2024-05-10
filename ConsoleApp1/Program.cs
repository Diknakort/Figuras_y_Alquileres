// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Factoria MiFactoria = new();
//var figura1 = MiFactoria.DameFigura(TipoFigura.Triangulo, 5);
var figura1 = MiFactoria.DameFigura(TipoFigura.Cuadrado, 7);
var figura2 = MiFactoria.DameFigura(TipoFigura.Circulo, 8);
var figura3 = MiFactoria.DameFigura(TipoFigura.Cuadrado, 9);
var figura4 = MiFactoria.DameFigura(TipoFigura.Circulo, 10);
var figura5 = MiFactoria.DameFigura(TipoFigura.Cuadrado, 6);
var figura6 = MiFactoria.DameFigura(TipoFigura.Circulo, 5);
// si no se define el visor en la Factoria:
//figura2.Visor = new VisionadorConsola();
//figura1.Visor = new VisionadorHTML();

Console.WriteLine($"Figura1: {figura5}");
//Console.WriteLine($"Figura2: {figura1}");
Console.WriteLine($"Figura1: {figura2}");

ColeccionFiguras MiTablero = new ();
MiTablero.Add(figura1);
MiTablero.Add(figura2);
MiTablero.Add(figura3);
MiTablero.Add(figura4);
MiTablero.Add(figura5);
MiTablero.Add(figura6);

Console.WriteLine(value: $"La cantidad de figuras total es: {MiTablero.CantidadDeFiguras()}.");
Console.WriteLine(value: $"La superficie total es: {MiTablero.SuperficieTotal()}.");
Console.WriteLine(value: $"El perímetro total es: {MiTablero.PerimetroTotal()}.");
Console.WriteLine(value: $"La figura más pequeña es: {MiTablero.FiguraMasPequena()}.");
Console.WriteLine(value: $"La media de superficie es: {MiTablero.MediaSuperficie()}.");
Console.WriteLine(value: $"La media de perímetro es: {MiTablero.MediaPerimetro()}.");




