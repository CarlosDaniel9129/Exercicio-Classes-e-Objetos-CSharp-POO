using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Calculadora
    {
        public int num1;
        public int num2;
        public string operacao;

        public void calcular()
        {
            if (num1 >= 0 & num1 <= 1000 & num2 >= 0 & num2 <= 1000)
            { 


                switch (operacao)
                {
                    case "+":
                        {
                            Console.WriteLine($"O RESULTADO da Operação Adição é: {num1 + num2}.");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine($"O RESULTADO da Operação Subtração é: {num1 - num2}.");
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine($"O RESULTADO da Operação Multiplicação é: {num1 * num2}.");
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine($"O RESULTADO da Operação Divisão é: {num1 / num2}.");
                            break;
                        }
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Os valores informados não se adequam aos permitidos pela calculadora");
            }
        }
    }
}
