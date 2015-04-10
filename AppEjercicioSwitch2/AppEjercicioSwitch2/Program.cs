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
            Console.WriteLine("Digite el numero del 1 al 5 en numero:");
            num= Console.ReadLine();               
            switch (num)
            {
                case "1":
                    Console.WriteLine("uno");
                    break;
                case "2":
                    Console.WriteLine("Dos");
                    break;
                case "3":
                    Console.WriteLine("Tres");
                    break;
                case "4":
                    Console.WriteLine("Cuatro");
                    break;
                case "5":
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("FUERA DEL RANGO");
                    break;



            }

            Console.ReadKey();

        }
    }
}
