
namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca Peca_M(int linha,int coluna)
        {
            return _pecas[linha, coluna];
        }

        public Peca Peca_M(Posicao pos)
        {
            return _pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPecas(Peca p,Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("There is a piece in this position");
            }
     
            _pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {

            if (Peca_M(pos) == null)
            {
                return null;
            }

            Peca p = Peca_M(pos);
            p.Posicao = null;

            _pecas[pos.Linha, pos.Coluna] = null;

            return p;

        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);

            return Peca_M(pos) != null;

        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Invalid position!");
            }
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }

            return true;
        }

    }
}
