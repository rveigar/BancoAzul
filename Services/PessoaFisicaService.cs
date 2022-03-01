using BancoAzul.Dados;
using BancoAzul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAzul.Services
{
    internal class PessoaFisicaService
    {

        //public bool Adicionar(string nome, string sobrenome, string endereco, int idade,  string cpf)
        public bool Adicionar( PessoaFisica pessoa)
        {
            var novaPessoa = new PessoaFisica();
            //var listaPessoas = new List<PessoaFisica>();

            //List<PessoaFisica> listaDePessoas;
            // listaDePessoas = PessoasRepository.PessoasFisicas;

            var listaDePessoas = PessoasRepository.PessoasFisicas;

            // precisei modificar Pessoa e PessoaFisica para tornar as variaveis public
            // Também acrescenter Usin BancoAzul.Model para poder acessar PessoaFisica

            /*
            novaPessoa.Nome = nome;
            novaPessoa.Sobrenome = sobrenome;
            novaPessoa.Endereco = endereco;
            novaPessoa.CPF = cpf;
            novaPessoa.Idade = idade;
            */
            novaPessoa = pessoa;
            if (novaPessoa.VerificarCPF(novaPessoa.CPF) && novaPessoa.VerificarMaioridade(novaPessoa.Idade))
            {
                //listaPessoas.Add(novaPessoa);
                listaDePessoas.Add(novaPessoa);
                
                return true;
            }
            else
            {
                return false;
            }

            
            

        }

        public List<PessoaFisica> Listar()
        {
            return PessoasRepository.PessoasFisicas;

        }
    }
}

   /* 
    
      foreach(PessoaFisica x in listaPessoas)
                    {
                        Console.WriteLine("valor de x {x}", x);
                    }

    
    }
   */