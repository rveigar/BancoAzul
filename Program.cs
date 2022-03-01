using BancoAzul.Dados;
using BancoAzul.Model;
using BancoAzul.Services;
using System;
using System.Collections.Generic;

namespace BancoAzul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // =========================
            var pessoaFisica = new PessoaFisica();
            //var cpf = "744.759.140-86";  cpf correto 74475914086
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
            Menu();

            void Menu()
            {
                int flag1 = 1;

                do
                {
                    Console.Clear();
                    Console.WriteLine("1- Cadastrar Pessoa Fisica");
                    Console.WriteLine("2- Listar Pessoa Fisica");
                    Console.WriteLine("3- Editar Pessoa Fisica");
                    Console.WriteLine("4- Excluir Pessoa Fisica");
                    Console.WriteLine("0- Sair");
                    Console.Write("Digite sua opção: ");

                    var resposta = int.Parse(Console.ReadLine());
                    switch (resposta)
                    {
                        case 1: Cadastrar(); break;
                        case 2: Listar(); break;
                        case 3: Editar(); break;
                        case 4: Excluir(); break;
                        case 0:
                        default: flag1 = 0; break;
                    }

                }
                while (flag1 == 1);
            }
                void Cadastrar()
                {

                int resp=0;
                    do
                    {

                    var pessoaFisica = new PessoaFisica();
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

                    retorno = inserirPessoaFisica.Adicionar( pessoaFisica);
                    //retorno = inserirPessoaFisica.Adicionar(pessoaFisica.Nome, pessoaFisica.Sobrenome, pessoaFisica.Endereco, pessoaFisica.Idade, pessoaFisica.CPF);
                    if (retorno)
                        {
                            Console.WriteLine("Pessoa Fisica foi adicionada");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Inserção de Pessoa Física falhou");
                            Console.ReadKey();
                        }

                        Console.WriteLine("Digite 1 para continuar a cadastrar Pessoa Fisica");
                        resp = int.Parse(Console.ReadLine());

                    } while (resp == 1);
                }
                void Listar()
                {
                   
                }
                void Editar()
                {

                }
                void Excluir()
                    {

                    }

        }
    } 
}

