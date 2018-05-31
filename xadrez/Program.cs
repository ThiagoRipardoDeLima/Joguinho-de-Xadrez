using System;
using tabuleiro;


namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.terminada)
            {
                Console.Clear();
                Tela.imprimeTabela(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executarMovimento(origem, destino);

            }

            

            
            

            Console.ReadLine();

        }
    }
}
