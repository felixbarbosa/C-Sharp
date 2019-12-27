using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O_3_Mini_Prova
{

    /*
     Crie uma classe Zoológico que possui 10 jaulas com um animal cada. Zoológico deve possuir o método
     visitar() que percorre as jaulas emitindo o som do animal de cada uma e fazendo o animal correr caso
     ele possua esse comportamento.
         */


    class Zoologico
    {

        public Animal[] jaulas = new Animal[10];//Cria um array com tamanho 10 de Animal

        public Zoologico(Animal [] _jaulas) //Construtor
        {
            this.jaulas = _jaulas;
        }

        public void visitar() //Visita as jaulas
        {
           for(int i = 0; i<10; i++) //Percorre todas as jaulas
            {
                
                if(jaulas[i] is Cachorro)//Verifica se o animal da jaula é um cachorro 
                                         //jaulas[i].GetType() == typeof(Cachorro)
                {
                    Console.WriteLine("É um cachorro!");
                    Cachorro cao = new Cachorro(jaulas[i].Nome, jaulas[i].Idade);//Cria um objeto de Cachorro
                    Console.WriteLine(cao.correr());
                    Console.WriteLine(jaulas[i].emitirSom());

                }
                else if (jaulas[i] is null){ //Verifica se a jaula está vazia
                    Console.WriteLine("Jaula Vazia!");
                }
                else
                {
                    Console.WriteLine("É uma prguiça!");
                    
                    Console.WriteLine(value: jaulas[i].emitirSom());
                }
            }
        }

    }
}
