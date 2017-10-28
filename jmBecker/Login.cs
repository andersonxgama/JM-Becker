using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmBecker
{
    class Login
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String usuario;
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String senha;
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private int tipo;
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}