using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace jmBecker
{
    class ContasReceber
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private SqlDecimal valor;
        public SqlDecimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int idCliente;
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
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

        private int idOs;
        public int IdOs
        {
            get { return idOs; }
            set { idOs = value; }
        }

        private int formaPagamento;
        public int FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        private DateTime dataDeposito;
        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }

        private int situacao;
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private DateTime dataPagamento;
        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }
    }
}
