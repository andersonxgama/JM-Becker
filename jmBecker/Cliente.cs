using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmBecker
{
    class Cliente
    {
        private int id;
        public int Id
        {
            get { return id; }
            internal set { id = value; }
        }

        private String endereco;
        public String Endereco
        {
            get { return endereco; }
            internal set { endereco = value; }
        }

        private String numero;
        public String Numero
        {
            get { return numero; }
            internal set { numero = value; }
        }

        private String complemento;
        public String Complemento
        {
            get { return complemento; }
            internal set { complemento = value; }
        }

        private String cep;
        public String Cep
        {
            get { return cep; }
            internal set { cep = value; }
        }

        private String bairro;
        public String Bairro
        {
            get { return bairro; }
            internal set { bairro = value; }
        }

        private String cidade;
        public String Cidade
        {
            get { return cidade; }
            internal set { cidade = value; }
        }

        private String uf;
        public String Uf
        {
            get { return uf; }
            internal set { uf = value; }
        }

        private String telefoneResidencial;
        public String TelefoneResidencial
        {
            get { return telefoneResidencial; }
            internal set { telefoneResidencial = value; }
        }

        private String telefoneComercial;
        public String TelefoneComercial
        {
            get { return telefoneComercial; }
            internal set { telefoneComercial = value; }
        }

        private String celular;
        public String Celular
        {
            get { return celular; }
            internal set { celular = value; }
        }

        private String email;
        public String Email
        {
            get { return email; }
            internal set { email = value; }
        }

        private int tipo;
        public int Tipo
        {
            get { return tipo; }
            internal set { tipo = value; }
        }

        private String observacoes;
        public String Observacoes
        {
            get { return observacoes; }
            internal set { observacoes = value; }
        }
    }
}