// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Modelo;
using ConsoleApp2.Garage;


////////// Coches potencia ///////////////
////método de generar un coche tradicional
//ConsoleApp2.Modelo.Coche MiCitroen = new ConsoleApp2.Modelo.Coche();
//MiCitroen.Matricula = "001010AB";
//MiCitroen.Cabe = true;
////método de generar un coche tradicional
//ConsoleApp2.Modelo.Coche MiSeat = new();
//MiSeat.Matricula = "001011AA";
//MiSeat.Cabe = true;
//// método de generar un coche para cambiar en tiempo de ejecución
//// solo hay que cambiar "Coche" para cambiar el tipo de objeto
//var MiFiat = new ConsoleApp2.Modelo.Coche();
//MiFiat.Matricula = "000001AA";
//MiFiat.Cabe = false;
//// RECOMENDADO
//// método de generar un coche para cambiar en tiempo de ejecución
//// solo hay que cambiar "Coche" para cambiar el tipo de objeto, menos texto escrito y solo una línea
//var MiMercedes = new ConsoleApp2.Modelo.Coche() { Cabe = true, Matricula = "001000DC" };
//var MiPorche = new ConsoleApp2.Modelo.Coche("010101ZA", false);
//var MiFerrari = new ConsoleApp2.Modelo.Coche("111000GA", true);
//var MiSkoda = new ConsoleApp2.Modelo.Coche("919911HF", true);
//var DiegoMercedes = new Vehiculo() { velocidad = 220, numRuedas = 4, potencia = 225 };
//var DiegoFerrari = new Vehiculo() { velocidad = 250, potencia = 300, numRuedas = 4 };
////var DiegoKawasaki = new Vehiculo() { velocidad = 140, numRuedas = 2, potencia = 45 };
//Console.WriteLine("Vehiculo 1, introduce la Velocidad: ");
//string dameTuVehiculo1Velodidad = Console.ReadLine()!;
//Console.WriteLine("Vehiculo 1, introduce el Potencia: ");
//string dameTuVehiculo1Potencia = Console.ReadLine()!;
//Console.WriteLine("Vehiculo 1, introduce el Numero de Ruedas: ");
//string dameTuVehiculo1Nruedas = Console.ReadLine()!;

//var DiegoKawasaki = new Vehiculo();
//DiegoKawasaki.velocidad = (int)double.Parse(dameTuVehiculo1Velodidad);
//DiegoKawasaki.potencia = (int)double.Parse(dameTuVehiculo1Potencia);
//DiegoKawasaki.numRuedas = (int)double.Parse(dameTuVehiculo1Nruedas);

//Console.WriteLine($"Hola, tu vehículo es: {DiegoKawasaki} y con una velocidad media falsa de " + Media((int)DiegoKawasaki.velocidad, (int)DiegoKawasaki.potencia, DiegoKawasaki.numRuedas));
//Console.WriteLine("Vehiculo 2, introduce la Velocidad: ");
//string dameTuVehiculo2Velodidad = Console.ReadLine()!;
//Console.WriteLine("Vehiculo 2, introduce el Potencia: ");
//string dameTuVehiculo2Potencia = Console.ReadLine()!;
//Console.WriteLine("Vehiculo 2, introduce el Numero de Ruedas: ");
//string dameTuVehiculo2Nruedas = Console.ReadLine()!;
//var DiegoOpel = new Vehiculo();
//DiegoOpel.velocidad = (int)double.Parse(dameTuVehiculo2Velodidad);
//DiegoOpel.potencia = (int)double.Parse(dameTuVehiculo2Potencia);
//DiegoOpel.numRuedas = (int)double.Parse(dameTuVehiculo2Nruedas);

//static int Media(int a, int b, int c)
//{
//    return (a * b) / c;
//}
//Console.WriteLine($"{DiegoOpel} y con una velocidad media falsa de " + Media((int)DiegoOpel.velocidad, (int)DiegoOpel.potencia, DiegoOpel.numRuedas));
////Console.WriteLine($"{DiegoKawasaki}");
////Console.WriteLine($"{DiegoFerrari}");

//////////////// ALQUILER ///////////////////
Console.WriteLine(" ");
Console.WriteLine("EJERCICIO - PRECIO HORA");
var alquilerMercedes = new ConsoleApp2.Garage.Coche(identificador: "01HH", tiempo: 3);
var alquilerPorche = new ConsoleApp2.Garage.Coche("010101ZA", 4, 1);
var alquilerFerrari = new ConsoleApp2.Garage.Coche("111000GA", 4, 3);
var alquilerSkoda = new ConsoleApp2.Garage.Coche("919911HF", 4, 5);


Console.WriteLine($"{alquilerFerrari}");

ConsoleApp2.Garage.AlquilableFactoryV01 Factoria = new AlquilableFactoryV01();

IAlquilable alquilable1 = Factoria.dameElemento((int)EnumTipos.Coche, "matricula1", 8);

IAlquilable alquilable2 = Factoria.dameElemento((int)EnumTipos.Furgoneta, "furgoJony", 5);

var alquilerMercedesVito = new ConsoleApp2.Garage.Furgoneta("01FF", 5, 3);
var alquilerMalacatones = new ConsoleApp2.Garage.Furgoneta("10FF", 5, 1);
(alquilable1 as ConsoleApp2.Garage.Coche).Visor = new VisionadorHTML();

alquilerMercedesVito.Visor = new VisionadorHTML();

Console.WriteLine($"Mercedes Vito: {alquilerMercedesVito}");
Console.WriteLine($"Para los Malacatones: {alquilerMalacatones}");