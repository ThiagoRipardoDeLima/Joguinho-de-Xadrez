using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno { get; set; }
        private Cor jogadorAtual { get; set; }
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementaQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.adicionaPeca(p, destino);
        }

        public void colocarPecas()
        {
            tab.adicionaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.adicionaPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            tab.adicionaPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            tab.adicionaPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            tab.adicionaPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());

        }

    }
}
