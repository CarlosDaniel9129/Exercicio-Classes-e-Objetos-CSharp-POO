using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Funcionario
    {
        public string nome;
        public string sexo;
        public string setor;

        public void imprimeDados()
        {
            Console.WriteLine($"Nome: {nome}\nSexo: {sexo}\nSetor: {setor}");
        }
    }
}
