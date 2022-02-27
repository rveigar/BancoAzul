using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAzul.Model
{
    internal class PessoaJuridica:Pessoa
    {
        string NomeFantasia;
        string CNPJ;

         public bool VerificarCNPJ(string cnpj) 
        {
            // 73.498.982/0001-67        73498982000167
            var verificadorCnpj = new CPFCNPJ.Main();
            var resultCNPJ = verificadorCnpj.IsValidCPFCNPJ(cnpj);
            return (resultCNPJ);

        }
    }
}
