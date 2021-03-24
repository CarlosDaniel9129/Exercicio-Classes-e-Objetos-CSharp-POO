using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.num1 = 0;
            calc.num2 = 20;
            calc.operacao = "+";

            /*chamo o metodo calcular da nossa classe Calculadora, onde ela 
            * confere a operação desejada e numeros desejados, realiza o calculo 
            * e imprime na tela*/

            calc.calcular();
        }
    }
}
