using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPFCNPJ;

namespace BancoAzul.Model
{
    internal class PessoaFisica:Pessoa
    {
        public string CPF;
        public int Idade;
        public string Sobrenome;

        bool MaiorIdade( int idade) 
        {
            if (idade >= 18)
                return true;
            else
                return false;
        }
        public bool VerificarCPF(string cpf) 
        {
            //check CPF
            //var verificadorCpf = new CPFCNPJ.Main(); sem acrescentar o using CPFCNPJ
            var verificadorCpf = new Main(); //não precisei usar CPFCNPJ.Main() pois coloquei o using CPFCNPJ
            var resultCPF = verificadorCpf.IsValidCPFCNPJ(cpf);
            return (resultCPF);

        }

        public bool VerificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
