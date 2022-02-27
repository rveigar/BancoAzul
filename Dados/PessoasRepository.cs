using BancoAzul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAzul.Dados
{
    internal class PessoasRepository
    {
        public static List<PessoaFisica> PessoasFisicas = new List<PessoaFisica>();
        public static List<PessoaJuridica> PessoasJuridicas = new List<PessoaJuridica>();
    }
}
