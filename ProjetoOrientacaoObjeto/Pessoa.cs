using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    internal class Pessoa
    {
        private string nome;
        private string email;
        private string cpf;
        private string telefone;
        private int idade;

        public void setNome(string nome)
        {
            //this.email = email;
            this.nome = nome;
            //this.cpf = cpf;
            //this.telefone = telefone;
            //this.idade = idade;
        }
        public string getNome()
        {
            return this.nome;
            //return this.email;
            //return this.cpf;
            //return this.telefone;
            //return this.idade;
        }
        public void setEmail(string email) 
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setCpf(string cpf) 
        {
            this.cpf = cpf;
        }
        public string getCpf() 
        {
            return this.cpf;
        } 
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone() 
        { 
            return this.telefone;
        }
        public void setIdade(int Idade) 
        {
            this.idade = Idade;
        }
        public int getIdade()
        { 
            return this.idade;
        }
    }
}
