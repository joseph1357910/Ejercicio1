using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Tipos de datos
            int num1 = 1;
            float num2 = 3.14f;
            decimal num3 = 15.15m;
            double num4 = 15.2;
            byte num5 = 24;
            long num6 = 131341324423;
            bool num7 = true;
            char num8 = 'a';
            //var//dynamic
            var variable = 15;
            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";

            //Arreglos
            int n = 4;//N vale 4 osea tienen que ser 4 nombres
            string[] musico = new string[n];//Se inicializa con new string y tiene que tener un tamaño que es 4
            musico[0] = "Jorge";
            musico[1] = "Paula";
            musico[2] = "Luis";
            musico[3] = "Tavo";
            Console.WriteLine("Lista de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            float[] salario = new float[4];

            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Digite el salario");
            salario[i] = float.Parse(Console.ReadLine());

            }


            Console.ReadLine();
            string[] nombres = new string[] { "Jorge", "Paula", "Luis", "Tavo" };

            n = 20;

            musico = new string[n];
        }
    }
}
