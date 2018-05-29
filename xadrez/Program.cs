using System;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tabuleiro tabuleiro;

            tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.adicionaPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.adicionaPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.adicionaPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));
            

            Tela.imprimeTabela(tabuleiro);

            Console.ReadLine();

        }
    }
}
