using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    internal class Cadastrar
    {
        private string ccodigo="";
        private string ddescricao="";
        private double vvalor;
        private double qquantidade;
        private double Total;

        public void setCodigo(string codigo)
        {
            this.ccodigo = codigo;
        }
        public string getCodigo()
        {
            return this.ccodigo;
        }
        public void setDescricao(string descricao)
        {
            this.ddescricao = descricao;
        }
        public string getDescricao()
        {
            return this.ddescricao;
        }
        public void setValor(double valor)
        {
            this.vvalor = valor;
        }
        public double getValor()
        { 
            return this.vvalor;
        }
        public void setQuatidade(double quatidade)
        {
            this.qquantidade = quatidade;
        }
        public double getQuantidade()
        { 
            return this.qquantidade;
        }
        public double getTotal()
        {
            Total = vvalor * qquantidade;
            return this.Total; 
        }
    }
}
