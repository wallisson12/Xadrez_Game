using System;
using tabuleiro;
using Xadrez_Game;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int _turno;
        private Cor _jogadorAtual;

        public PartidaDeXadrez()
        {
             tab = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Azul;
            ColocarPecas();
        }

        private void ColocarPecas()
        {
            tab.ColocarPecas(new Torre(tab, Cor.Azul), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPecas(new Rei(tab, Cor.Azul), new PosicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Azul), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Azul), new PosicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Azul), new PosicaoXadrez('d', 2).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Azul), new PosicaoXadrez('e', 2).ToPosicao());

            tab.ColocarPecas(new Torre(tab, Cor.Amarela), new PosicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPecas(new Rei(tab, Cor.Amarela), new PosicaoXadrez('d', 8).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Amarela), new PosicaoXadrez('e', 8).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Amarela), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Amarela), new PosicaoXadrez('d', 7).ToPosicao());
            tab.ColocarPecas(new Torre(tab, Cor.Amarela), new PosicaoXadrez('e', 7).ToPosicao());
        }

        public void ExecutaMovimento(Posicao origem,Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);

            p.ImcrementaMovimento();

            Peca pecaCap = tab.RetirarPeca(destino);

            tab.ColocarPecas(p, destino);
        }
    }
}
