using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            int metros, cm, mm;
            Console.WriteLine("Digite o número de metros: ");
            metros = int.Parse(Console.ReadLine());
            cm = metros * 100;
            mm = metros * 1000;
            Console.WriteLine("A quantidade em cm é " + cm);
            Console.WriteLine("A quantidade em mm é " + mm);
            Console.ReadKey();

            //Exercicio 2
            //int fa1, resInt;
            //float fa2, resFloat;
            //Console.WriteLine("Entre com o Fahrenheit int:");
            //fa1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o Fahrenheit float:");
            //fa2 = float.Parse(Console.ReadLine());

            //resInt = (fa1 - 32) * (5 / 9);
            //resFloat = (fa2 - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("Resultado float " +resFloat);
            //Console.WriteLine("Resultado int " +resInt);
        }
    }
}
