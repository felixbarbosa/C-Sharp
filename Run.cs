using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O_3_Mini_Prova
{
    class Run
    {
        static void Main(string[] args)
        {

            Cachorro cao = new Cachorro("bob", 10);
            Cachorro cao2 = new Cachorro("fred", 4);
            Preguica bixo = new Preguica("stella", 15, true);

            Animal[] jaulas = new Animal[10];

            jaulas[0] = cao;
            jaulas[1] = bixo;
            jaulas[2] = cao2; 

            Zoologico zoo = new Zoologico(jaulas);

            zoo.visitar();
            Console.ReadLine();

            //Console.WriteLine(bixo.emitirSom());
            //Console.WriteLine(bixo.escalarArvore());
            //Console.ReadLine();

            //Console.WriteLine(cao.emitirSom());
            //Console.WriteLine(cao.correr());
            //Console.ReadLine();

        }
    }
}
