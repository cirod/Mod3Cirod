using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Desarrollar un programa que permita la carga de n valores por teclado y nos muestre 
             * posteriormente la suma de los valores ingresados y su promedio.

            */

            int promedio = 0;
            Console.WriteLine("Por favor Digite el numero de valores: ");
            int cont = int.Parse(Console.ReadLine());
            int cont2 = cont;
            while (cont > 0)
            {
                Console.WriteLine("Por favor digite el numero "+cont+" :");
                int num = int.Parse(Console.ReadLine());
                promedio += num;

                cont--;
            }
            Console.WriteLine("La Suma de los numeros es: "+promedio);

            promedio = promedio / cont2;
            Console.WriteLine("El promedio de los numeros es: " + promedio);


            Console.ReadKey();

        }
    }
}
