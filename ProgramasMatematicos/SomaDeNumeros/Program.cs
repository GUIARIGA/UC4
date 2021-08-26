using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string > texto
            int > inteiro
            Double e Float > decimais 
                */
            Double n1 = 0;
            Double n2 = 0;
            Double res = 0;
            string pergunta = "";
            string escolha = "";
            Console.WriteLine("Programa que soma dois números");
            
            Console.Write("Escvreva o primeiro número:");
            pergunta = Console.ReadLine();
            n1 = Convert.ToDouble(pergunta);
            
            Console.Write("Escreva o segunbdo número:");
            pergunta = Console.ReadLine();
            n2 = Convert.ToDouble(pergunta);

            Console.WriteLine("Escolha a operação matemátia ");
            Console.Write("SOMA [+]");
            Console.Write("SUBTRAÇÃO [-]");
            Console.Write("DIVISÃO [/]");
            Console.Write("MULTIPLICAÇÃO [*]");
            pergunta = Console.ReadLine();
            escolha = Convert.ToString(pergunta);

            if (escolha == "-")
            {
                res = n1 - n2;
                Console.Write(n1 + "-" + n2 + "=" + res);
            } else {

                if (escolha == "+"){
                    res = n1 + n2;
                    Console.Write(n1 + "+" + n2 + "=" + res);
                }
                else (escolha == "*") {
                    res = n1 * n2;
                    Console.Write(n1 + "x" + n2 + "=" + res);
                }

                res = n1 / n2;
                Console.Write(n1 + "/" + n2 + "=" + res);
                
            }
            Console.ReadKey();

        }
    }
}
