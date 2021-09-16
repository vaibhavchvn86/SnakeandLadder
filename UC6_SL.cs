using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC6_SL
    {
        public static void DieCount()
        {
            int position = 0;
            int diecount = 0;
            while (position != 100)
            {
                Random die = new Random();
                int a = die.Next(1, 7);
                Console.WriteLine("Dice obtain is " + a);
                Random option = new Random();
                int Opt = option.Next(1, 4);
                diecount++;
                switch (Opt)
                {
                    case 1:
                        Console.WriteLine("Player choose No Play");
                        break;
                    case 2:
                        Console.WriteLine("Player got a Snake position will be decrease");
                        if ((position - a) < 0)
                            position = 0;
                        else
                            position -= a;
                        break;
                    case 3:
                        Console.WriteLine("Player got a Ladder");
                        if (position > 100)
                            position = position;
                        else
                            position += a;
                        Console.WriteLine("Player Won the game");
                        break;
                }
                Console.WriteLine("player position " + position);
            }

            Console.WriteLine("No. of times Dice rolled by player is " + diecount);
        }
    }
}
