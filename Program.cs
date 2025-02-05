using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
     class Program {
        static void Main(string[] args) 
        {
            Menu();
        }
        static void Menu() {
            Console.Clear();

            Console.WriteLine("Bem Vindo a Calculuda a calculadora do gabriel");
            Console.WriteLine("");
            Console.WriteLine("Selecione qual tipo de operação deseja utilizar");

            Console.WriteLine("(1) SOMA");
            Console.WriteLine("(2) SUBTRAÇÃO");
            Console.WriteLine("(3) DIVISÃO");
            Console.WriteLine("(4) MULTIPLICAÇÃO");
            Console.WriteLine("(5) SAIR");

            short res = short.Parse(Console.ReadLine());

            switch (res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break; 

            }
        }

        static void Soma()
            {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 + v2;
            Console.WriteLine($"O resultador da soma é {resultado} ");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao() {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultador da subtração é {resultado} ");
            Console.ReadKey();
            Menu();
        }

        static void Divisao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é:  {resultado} ");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O Resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}
