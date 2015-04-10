using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTercerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3,suma;
            Console.WriteLine("Digite Nota 1 ");
            nota1=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 2 ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 3 ");
            nota3 = float.Parse(Console.ReadLine());
            suma=nota1+nota2+nota3;
            suma = suma / 3;
            if(suma>=3) 
            {
                Console.WriteLine("Promocionado con Nota de:"+suma);
            }
            else
                {
                    Console.WriteLine("Perdio con Nota de:"+suma);   
                }
            Console.ReadKey();
        }
    }
}
