using System;

namespace prueba1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, perimetro;
			string linea;
			Console.WriteLine ("Programa que calcula el perimetro WOWOWOOWOWOWO");
			Console.WriteLine ("Ingrese el lado");
			linea=Console.ReadLine ();
			lado = float.Parse (linea);
			perimetro = 4 * lado;
			Console.WriteLine ("El perimetro del cuadrado es:"
			+ perimetro);
			Console.ReadKey ();
		}
	}
}
