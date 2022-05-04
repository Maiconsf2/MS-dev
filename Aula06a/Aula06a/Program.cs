using System;

namespace Aula06a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representação do mundo real.

            //CLASSE / OBJETO = Físico / Abstrato
            // POO = PROGRAMAÇÃO ORIENTADA A OBJETO

            //Uma classe possui:

            // propriedade (atributos) / caracteristicas;
            // métodos (funções)
            // eventos (o que é feito durante uma ação)

            // POO = PROGRAMAÇÃO ORIENTADA A OBJETO

            //4 PILARES DE OO;

            //ENCAPSULAMENTO, ABSTRAÇÃO, HERANÇA E POLIMORFISMO.

            // 1º - PILAR ENCAPSULAMENTO
            //AGRUPAR O QUE FAZ SENTIDO ESTAR JUNTO.

            //2º - PILAR ABSTRAÇÃO
            // ATO DE ESCONDER OS DETALHES (ESCONDER AS METODOS)

            //3º HERANÇA
            //CAPACIDADE DE UM OBJETO HERDAR, PROPRIEDADES.
            //METODOS E EVENTOS DE OUTRO OBJETO.


            //4º POLIMORFISMO - QUANDO UM METODO PODE SER EXECUTADO
            // DE FORMAS DIFERENTES
            // EX (Classe, animal com o metodo emitir som)


            //colocar um obj na memoria 
            //instanciar uma classe.

            Carro fusca = new Carro();
            fusca.placa = "zzz";
            fusca.chassi = "111";
            fusca.peso = 20;

            fusca.Andar();


            Moto suzuki = new Moto();
            suzuki.placa = "aaa";
            suzuki.chassi = "4444";
            suzuki.guidao = "";
            suzuki.Andar();
        }


        //CRIAR UM OBJETO CARRO.

        class Carro
        {
            //Todas as variaveis de uma classe são chamadas de propriedades.

            //niveis de acesso.
            // public = publico
            // private = private

            //se nao colocarmos nada o pradrão é private.

            public string placa;
            public string chassi;
            public string cor;
            public int peso;


            //todas as funções são chamadas de métodos.
            public void Andar()
            {
                ConsultarQuantidadeCombustivel();

            }

            void LigarSeta()
            {


            }

            void ConsultarQuantidadeCombustivel()
            {


            }



        }


        //: Carro moto herda todas as propriedades e metodos
        //publicos do Carro.

        class Moto : Carro
        {
            public string guidao;



        }
    }
}
