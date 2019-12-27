using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O_3_Mini_Prova
{

    /*Animal possui os atributos nome e idade e o método emitirSom(), que retornará uma string formada
     pelo nome do animal concatenado com ":" concatenado com "NHA NHA NHA"
         */



    class Animal
    {

        private string nome;
        private int idade;

        public Animal(string _nome, int _idade)
        {
            this.Nome = _nome;
            this.Idade = _idade;
        }

        public virtual string emitirSom()
        {
            return this.nome + ": " + "NHA NHA NHA";
        }

        /*public string getNome() get e set do atributo nome(JAVA)
        {
            return this.nome;
        }

        public void setNome(string newNome)
        {
           this.nome = newNome;
        }*/

        public string Nome //get e set do atributo nome (C#)
        {
            get { return nome; } 
            set { nome = value; }
        }

        /* public int getIdade() get e set do atributo idade(JAVA)
         {
             return this.idade;
         }

         public void setIdade(int newIdade)
         {
             this.idade = newIdade;
         }*/

        public int Idade //get e set do atributo idade(C#)
        {
            get { return idade; }
            set { idade = value; }
        }
    }
}
