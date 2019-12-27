using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O_3_Mini_Prova
{

    /*
     Pregruiça sobrescreve o método emitirSom() retornando uma string formada pelo retorno de emitirSom()
     de Animal concatenada com "ZZZ".

     Preguiça possui um método escalarArvore() que deve atualizar um atributo do tipo boolean de preguiça
     indicando se ele está em cima ou não de uma árvore (se o atributo estiver falso, escalarArvore() torna-o
     verdadeiro, e se ele estiver verdadeiro, escalarArvore() torna-o falso).
         */


    class Preguica : Animal
    {

        public bool cimaArvore = false;

        public Preguica (string _nome, int _idade, bool _cimaArvore) : base(_nome, _idade)
        {//Como Preguiça herda de Animal, o construtor de Preguiça tem como base o construtor de Animal.
            this.cimaArvore = _cimaArvore;
        }

        public override string emitirSom()
        {
            return base.emitirSom() + " ZZZ"; //Retorna o metodo emitirSom() da base, que no caso é Animal
                                              //Concatena com "ZZZ"
        }

        public bool escalarArvore()
        {
            if(cimaArvore == false)
            {
                cimaArvore = true;
                return cimaArvore;
            }
            else
            {
                return cimaArvore;
            }
        }
    }
}
