using BancoAzul.Model;
using BancoAzul.Services;
using System;

namespace BancoAzul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            // =========================
            var pessoaFisica = new PessoaFisica();
            //var cpf = "744.759.140-86";  rg correto 74475914086
            var cpf = "744.759.140-86";
            var retorno = pessoaFisica.VerificarCPF(cpf);
            Console.WriteLine($"o valor do cpf {cpf} é {retorno}");
            
            // =========================
            var pessoaJuridica = new PessoaJuridica();
            //var cnpj = "73498982000167"; cnpj correto
            var cnpj = "73498982000167";
            retorno = pessoaJuridica.VerificarCNPJ(cnpj);
            Console.WriteLine($"O valor do cnpj {cnpj} é {retorno}");

            // =========================

            Console.WriteLine("Digite o nome: ");
            pessoaFisica.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome: ");
            pessoaFisica.Sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o idade: ");
            pessoaFisica.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o endereco: ");
            pessoaFisica.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o cpf: ");
            pessoaFisica.CPF = Console.ReadLine();

            var inserirPessoaFisica = new PessoaFisicaService();
            retorno = inserirPessoaFisica.Adicionar(pessoaFisica.Nome, pessoaFisica.Sobrenome, pessoaFisica.Endereco, pessoaFisica.Idade, pessoaFisica.CPF);
            if (retorno)
            {
                Console.WriteLine("Pessoa Fisica foi adicionada");
            }
            else
            {
                Console.WriteLine("Inserção de Pessoa Física falhou");
            }

        }
    }
}
