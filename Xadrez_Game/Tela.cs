﻿using System;
using tabuleiro;

namespace Xadrez_Game
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i=0;i<tab.Linhas;i++)
            {

                for(int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca_M(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca_M(i,j) + " ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
