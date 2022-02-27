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

        public bool Adicionar(string nome, string sobrenome, string endereco, int idade,  string cpf)
        {
            var novaPessoa = new PessoaFisica();
            var listaPessoas = new List<PessoaFisica>();
            // precisei modificar Pessoa e PessoaFisica para tornar as variaveis public
            // Também acrescenter Usin BancoAzul.Model para poder acessar PessoaFisica

            novaPessoa.Nome = nome;
            novaPessoa.Sobrenome = sobrenome;
            novaPessoa.Endereco = endereco;
            novaPessoa.CPF = cpf;
            novaPessoa.Idade = idade;

            if (novaPessoa.VerificarCPF(cpf) && novaPessoa.VerificarMaioridade(idade))
            {
                listaPessoas.Add(novaPessoa);
                return true;
            }
            else
            {
                return false;
            }
            
            

        }


    }
}
