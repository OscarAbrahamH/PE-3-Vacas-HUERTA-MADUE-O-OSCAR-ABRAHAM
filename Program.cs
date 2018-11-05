using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PE_3_Vacas_HUERTA_MADUEÑO_OSCAR_ABRAHAM
{
    class ClaseVacas
    {
        public static int Sumas(IEnumerable V)
        {
            int suma = 0;
            foreach (Object obj in V) //SE REALIZA LA SUMA DE LAS VACAS
            {
                suma = suma + int.Parse(string.Format("{0}", obj));
            }
            return suma;
        }

        public void Imprimir()
        {
            Console.WriteLine("Bob le toma 2 minutos cruzar el puente");
            Console.WriteLine("Mazie le toma 2 minutos cruzar el puente");
            Console.WriteLine("Daisy le toma 4 minutos cruzar el puente");
            Console.WriteLine("Crazy le toma 10 minutos cruzar el puente");
            Console.WriteLine("Lazy le toma 20 minutos cruzar el puente");
            
        }
        static void Main(string[] args)
        {
            ClaseVacas figura1 = new ClaseVacas();
            Stack<int> Vacas = new Stack<int>(); //AGREGAR VALOR A LAS VACAS
            figura1.Imprimir();
            Vacas.Push(2);
            Vacas.Push(2);
            Vacas.Push(4);
            Vacas.Push(2);
            Vacas.Push(20);
            Console.WriteLine(" La suma de los minutos es de: " + Sumas(Vacas));
            Console.ReadKey();
        }
    }
}
