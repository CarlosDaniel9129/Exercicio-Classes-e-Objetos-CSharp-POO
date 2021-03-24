using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            func.nome = "Carlos";
            func.sexo = "Masculino";
            func.setor = "Informática";
            func.imprimeDados();
           
        }
    }
}
