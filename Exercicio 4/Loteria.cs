using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Loteria
    {
        public int totalNumeros;
        public int intervalo;

        public void sortear()
        {
            int maxNum = totalNumeros;
            int maxInter = intervalo;


            Random numAlea = new Random();  
            for (int i = 0; i < maxNum; i++)
            {
                                       /*o intervalo se da, de 0 a intervalo informado, e nao de 0, intervalo*/
            int sorteado = numAlea.Next(maxInter);
            Console.WriteLine($"{sorteado} \n");  
            }                   
                  
        }

    }
}
