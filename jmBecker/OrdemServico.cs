using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace jmBecker
{
    class OrdemServico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private SqlDecimal valor;

        public SqlDecimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private String observacoes;

        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }
}
