using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHospital
{
    class Paciente
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Olá, seja bem-vindo!\nEscolha umas das seguintes opções:");
                Console.WriteLine("\n1 - Cadastrar Pacientes");
                Console.WriteLine("2 - Lista de Pacientes");
                Console.WriteLine("3 - Atender um Paciente");
                Console.WriteLine("4 - Alterar dados do Paciente");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Clear();
                    Cadastro pessoa = new Cadastro();
                    pessoa.CadastroP();

                    Cadastro pessoaCadastro = new Cadastro();
                    pessoa.exibirInfo();
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--- Lista do Pacientes ---");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("--- Atender Paciente ---");
                    Console.ReadKey();
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.WriteLine("--- Alterar dados do Paciente ----");
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida");
                    Console.ReadKey();
                }

            }
        }
    }
}
