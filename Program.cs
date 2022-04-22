using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display d = new Display();
            Console.WriteLine(d.Intro());
            Board b = new Board();
            int rows = 5;
            int cols = 11;
            int mines = 5;
            b.newTileMap(rows, cols, mines);

            string input;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("0 1 2 3 4 5 6 7 8 9 10 ");
                Console.WriteLine("---------------------- ");

                b.Display();

                Console.WriteLine("Please enter x & y coordinates <x,y> : ");
                input = Console.ReadLine();
                string[] xy = input.Split(",");
                if (xy.Length < 2)
                {
                    isRunning = false;
                    Console.WriteLine("Invalid input, run the game again");
                }
                else
                {
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);

                    b.RevealTile(x, y);

                    if (b.Win())
                    {
                        Console.WriteLine("Congrats, you won!");
                        Environment.Exit(0);
                    }
                    //hb.newTileMap(10,10,14);}
                    if (b.GameOver())
                    {
                        Console.WriteLine("Sorry, GAME OVER");
                        b.Display();
                        b.RevealTile(x, y);
                        Environment.Exit(0);
                        //b.newTileMap(10,10,14);
                    }

                }

            }

        }
    }
}
