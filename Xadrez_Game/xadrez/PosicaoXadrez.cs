using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public int Linha { get; private set; }
        public char Coluna { get; private set; }

        public PosicaoXadrez(char coluna,int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            //Utiliza a tabela Ascii para assim dois chars da um numero inteiro
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
