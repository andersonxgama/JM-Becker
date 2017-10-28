using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace jmBecker
{
    class ContasPagar
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private SqlDecimal valor;
        public SqlDecimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private DateTime dataVencimento;
        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private DateTime dataPagamento;
        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        private String descricao;
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private String observacoes;
        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        private int situacao;
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}