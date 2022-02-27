using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAzul.Model
{
    internal class Pessoa
    {
        // If the variable belongs at class scope, give it
        // an explicit type. Otherwise move it inside
        // the method where it will be used.
        //public var CPF = "000.000.000-00";
        public string Nome;
        public string Endereco;
        ContaCorrente ContaCorrente;



    }
}
