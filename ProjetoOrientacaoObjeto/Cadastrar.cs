using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    internal class Cadastrar
    {
        private string codigo;
        private string descricao;
        private int valor;
        private int quantidade;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setValor(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        { 
            return this.valor;
        }
        public void setQuatidade(int quatidade)
        {
            this.valor = quatidade;
        }
        public int getQuantidade()
        { 
            return this.quantidade;
        }
    }
}
