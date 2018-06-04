using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        PartidaDeXadrez partida;
        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas,tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirPosicao(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //NE - Nordeste
            pos.definirPosicao(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //direita
            pos.definirPosicao(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //SE - Sudeste
            pos.definirPosicao(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //abaixo
            pos.definirPosicao(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //SO - Sudoeste
            pos.definirPosicao(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //Esquerda
            pos.definirPosicao(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //NO - Noroeste
            pos.definirPosicao(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.linha, pos.coluna] = true;

            //#jogadaespecial roque
            if(qteMovimentos == 0 && !partida.xeque)
            {
                //jogadaespecial roque pequeno
                Posicao posT1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao P1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao P2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if (tab.peca(P1) == null && tab.peca(P2) == null)
                        mat[P2.linha, P2.coluna] = true;
                }

                //jogadaespecial_roque_grande
                Posicao posT2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao P1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao P2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao P3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tab.peca(P1) == null && tab.peca(P2) == null && tab.peca(P3) == null)
                        mat[P2.linha, P2.coluna] = true;
                }
                
            }

            return mat;
        }
    }
}
