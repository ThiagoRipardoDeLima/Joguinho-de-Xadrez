using System;
using tabuleiro;

namespace xadrez
{
    class Tela
    {
        public static void imprimeTabela(Tabuleiro tabuleiro)
        {

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                        continue;
                    }
                    Console.Write(tabuleiro.peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
