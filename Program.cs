using System;

namespace Atividade_SI
{
    class program
    {
        static void Main(string[] args)
        {
            Cliente guilherme = new Cliente();
            guilherme.Cpf = "342.456.234-76";
            guilherme.Nome = "guilherme";
            guilherme.Rua = "rua do cabelin";
            guilherme.Numero = 6969;
            guilherme.Bairro = "Bairro do Cabelin";
            guilherme.Cidade = "CabelinLand";
            guilherme.Cep = "12312-354";
            guilherme.CidadeNome = "CabelinLand";
            guilherme.EstadoNome = "São Omar";
            guilherme.EstadoSigla = "SO";

            Console.WriteLine("Nome: " + guilherme.Nome);
            Console.WriteLine("Cpf: " + guilherme.Cpf);
            Console.WriteLine("Rua: " + guilherme.Rua);
            Console.WriteLine("Numero: " + guilherme.Numero);
            Console.WriteLine("Bairro: " + guilherme.Bairro);
            Console.WriteLine("Cidade: " + guilherme.Cidade);
            Console.WriteLine("Cep: " + guilherme.Cep);
            Console.WriteLine("EstadoNome: " + guilherme.EstadoNome);
            Console.WriteLine("EstadoSigla: " + guilherme.EstadoSigla);



        }
    }
}