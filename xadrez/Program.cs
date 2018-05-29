using System;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3,4);
            Tabuleiro tabuleiro;

            tabuleiro = new Tabuleiro(8, 8);


            Tela.imprimeTabela(tabuleiro);

            Console.ReadLine();

        }
    }
}
