using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmBecker
{
    class PessoaFisica : Cliente
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String cpf;
        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private String rg;
        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }
    }
}