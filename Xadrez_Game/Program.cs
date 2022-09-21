using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrez_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPecas(new Torre(tab,Cor.Rosa),new Posicao(0,0));
                //tab.ColocarPecas(new Torre(tab, Cor.Rosa), new Posicao(1, 3));
                //tab.ColocarPecas(new Rei(tab, Cor.Rosa), new Posicao(2,4));


                //Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez pos = new PosicaoXadrez('c',7);

                Console.WriteLine(pos.ToPosicao());

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
