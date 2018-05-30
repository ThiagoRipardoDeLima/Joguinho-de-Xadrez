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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                        continue;
                    }
                    imprimePeca(tabuleiro.peca(i,j));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Write("  a b c d e f g h");
        }

        public static void imprimePeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
