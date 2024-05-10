// See https://aka.ms/new-console-template for more information

using MedirDiametroSuperficie.Superficies;

IFactoriaMedibles figura1 = EnumTipos.dameSuperficie((int)EnumTipos.Circulo, 8);


var figura3 = new Cuadrado( 3 );
var figura2 = new Circulo("10FF", 5, 1);
(figura1 as MedirDiametroSuperficie.Superficies.Circulo).Visor = new VisionadoConsola();

figura2.Visor = new VisionadoConsola();