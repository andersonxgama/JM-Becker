using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmBecker
{
    class PessoaJuridica : Cliente
    {
        private String razaoSocial;
        public String RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        private String nomeFantasia;
        public String NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        private String representante;
        public String Representante
        {
            get { return representante; }
            set { representante = value; }
        }

        private String cnpj;
        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}
