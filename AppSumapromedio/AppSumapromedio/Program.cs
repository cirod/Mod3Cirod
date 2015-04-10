using System;

namespace prueba1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float num1, num2,num3,num4, res1,res2;
			Console.WriteLine ("que suma 2 y calcula el promedio de los otros 2 WOWOWOOWOWo son 4 numeros ");
			Console.WriteLine ("Ingrese el primer numero");
			num1 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese el segundo numero");
			num2 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese el tercer numero");
			num3 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingrese el cuarto numero");
			num4 = float.Parse (Console.ReadLine ());
			res1 = num1 + num2;
			res2 = (num3 + num4)/2;
			Console.WriteLine ("la suma de los 2 primeros es:"
				+ res1);
			Console.WriteLine ("la del producto de los otros 2 es:"
				+ res2);

			Console.ReadKey ();
		}
	}
}
