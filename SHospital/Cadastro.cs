using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHospital
{
    class Cadastro
    {
        public string nome, dataN, sexo, endereco, numC, CPF, telefone, prenf;
        public char conf;

        public void CadastroP()
        {
            Console.WriteLine("--- CADASTRO DO PACIENTE ---");
            Console.WriteLine("\nInsira as seguintes informações do paciente: ");

            Console.WriteLine("\nNome:");
            nome = Console.ReadLine();

            Console.WriteLine("\nCPF:");
            CPF = Console.ReadLine();

            Console.WriteLine("\nData de nascimento:");
            dataN = Console.ReadLine();

            Console.WriteLine("\nSexo: [M / H]");
            sexo = Console.ReadLine();

            Console.WriteLine("\nEndereço:");
            endereco = Console.ReadLine();

            Console.WriteLine("\nNumero da Residência:");
            numC = Console.ReadLine();

            Console.WriteLine("\nTelefone:");
            telefone = Console.ReadLine();

            Console.WriteLine("\nO paciente é preferencial? [S / N]");
            prenf = Console.ReadLine();

        }
        public void exibirInfo()
        {
            Console.Clear();
            Console.WriteLine("\nCONFIRA OS DADOS INSERIDOS:");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", CPF);
            Console.WriteLine("Data de Nascimento: {0}", dataN);
            Console.WriteLine("Sexo: {0}", sexo);
            Console.WriteLine("Endereço: {0}", endereco);
            Console.WriteLine("Número: {0}", numC);
            Console.WriteLine("Telefone: {0}", telefone);
            Console.WriteLine("Preferencial: {0}", prenf);

            Console.WriteLine("\nTudo certo? Confirme com ENTER");
            conf = Console.ReadKey().KeyChar;
            Console.Clear();
        }
    }
}