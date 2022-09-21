using System;
using tabuleiro;

namespace Xadrez_Game
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            int num = 8;

            for (int i=0;i<tab.Linhas;i++)
            {
                Console.Write($"{num}|");
                num--;

                for(int j = 0; j <tab.Colunas; j++)
                {
                    if (tab.Peca_M(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca_M(i, j));
                        Console.Write(" ");
                    }

                    
                }

                Console.WriteLine();
            }

            Console.WriteLine("  ---------------");

            Console.Write("  A ");
            Console.Write("B ");
            Console.Write("C ");
            Console.Write("D ");
            Console.Write("E ");
            Console.Write("F ");
            Console.Write("G ");
            Console.Write("H  ");
            


        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Amarela)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
