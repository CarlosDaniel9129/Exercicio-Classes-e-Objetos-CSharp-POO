using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Tabuada
    {
        public int potencia;
        

        public void calcular()
        {
            double result = 0;

            for (int i = 0; i <= 10; i++)
            {
                result = potencia * i;
                Console.WriteLine($" {potencia} X {i} = {result}\n");
            }
        }
    }
}
