using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHospital
{
    class Lista
    {
        Cadastro[] lista = new Cadastro[3];

        public void cadastro()
        {
            Console.WriteLine("--- Fila de Paciente ---");

            Cadastro lista = new Cadastro();
            lista[0].nome = Console.ReadLine();

        }


    }
}
