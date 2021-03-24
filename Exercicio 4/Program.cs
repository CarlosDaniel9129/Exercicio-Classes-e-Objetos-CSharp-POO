using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Loteria sort = new Loteria();
            sort.totalNumeros = 5;
            sort.intervalo = 10;
            sort.sortear();
        }
    }
}
