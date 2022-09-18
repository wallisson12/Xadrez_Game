using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiroo { get; protected set; }

        public Peca(Posicao posicao, Cor cor,Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiroo = tab;
        }
    }
}
