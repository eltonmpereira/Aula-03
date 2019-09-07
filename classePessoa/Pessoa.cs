using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassePessoa
{
    class Pessoa
    {
        private String nome;
        private int idade;
        private String rg;

        public Pessoa() { }

        public Pessoa(String nome, String rg, int idade)
        {
            this.nome = nome;
            this.rg = rg;
            this.idade = idade;
        }

        public void Nome (String nome)
        {
            this.nome = nome;
        }
        public String Nome()
        {
            return this.nome;
        }
        public void Rg (String rg)
        {
            this.rg = rg;
        }
        public String Rg()
        {
            return this.rg;
        }
        public void Idade(int idade)
        {
            this.idade = idade;
        }
        public int Idade()
        {
            return this.idade;
        }
       
    }
        
}