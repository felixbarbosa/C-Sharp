using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O_3_Mini_Prova
{

    /*
     Cachorro sobrescreve o método emitirSom() retornando uma string formada pelo nome do cachorro 
     concatenado com ":" concatenado com "AU AU AU"

     Cachorro possui o método correr() que irá retornar um double formado por 20.0 menos a idade
     do cachorro dividido por 3.
         */


    class Cachorro : Animal
    {

        public Cachorro (string _nome, int _idade) : base(_nome, _idade)
        {
        }

        public override string emitirSom()
        {
            return this.Nome + ": " + "AU AU AU";
        }

        public double correr()
        {
            return 20.0 - (this.Idade / 3);
        }

    }
}
