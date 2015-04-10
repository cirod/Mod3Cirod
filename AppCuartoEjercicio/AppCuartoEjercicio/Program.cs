using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuartoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, xxx;
            Console.WriteLine("Este programa si el num 1 es mayor al segundo se sumara y se dira la diferencia entre estos si no mostrara su producto y division");
            Console.WriteLine("Por favor Digite el numero 1");
            num1=float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor Digite el numero 2");
            num2 = float.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                xxx=num1+num2;
                Console.WriteLine("El primer numero es mayor y su suma es:"+xxx);
                xxx=num1-num2;
                Console.WriteLine("y la diferencia entre los 2 es:"+xxx);

            }
            else
            {
                xxx = num1 * num2;
                Console.WriteLine("El primer numero es menor y su producto es:"+xxx);
                xxx = num1 / num2;
                Console.WriteLine("El primer numero es menor y su division es:" + xxx);

            }
            Console.ReadKey();

        }
    }
}
