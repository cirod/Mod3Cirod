using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjercicioswitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingresar un valor entero entre 1 y 5. Luego mostrar en español el valor ingresado. 
            // Si se ingresa un valor fuera de dicho rango mostrar un mensaje indicando tal situación.
            string num;
            Console.WriteLine("Digite el numero en letras:");
            num = Console.ReadLine();
                switch(num.ToUpper())
                {
                    case "UNO":
                        Console.WriteLine(1);
                        break;
                    case "DOS":
                        Console.WriteLine(2);
                        break;
                    case "TRES":
                        Console.WriteLine(3);
                        break;
                    case "CUATRO":
                        Console.WriteLine(4);
                        break;
                    case "CINCO":
                        Console.WriteLine(5);
                        break;
                    default:
                        Console.WriteLine("FUERA DEL RANGO");
                        break;


                    
                }

                Console.ReadKey();

        }
    }
}
