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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.ImprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
