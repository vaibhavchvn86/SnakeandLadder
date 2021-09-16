using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC7_SL
    {
        public static void TwoPlayer()
        {
            int player1 = 0;
            int player2 = 0;
            int diecount1 = 0;
            int diecount2 = 0;
            while ((player1 != 100) || (player2 != 100))
            {
                Random die = new Random();
                int d1 = die.Next(1, 7);
                int d2 = die.Next(1, 7);
                Console.WriteLine("Dice obtain by player1 is " + d1);
                Console.WriteLine("Dice obtain by player2 is " + d2);
                Random option = new Random();
                int Opt = option.Next(1, 4);
                diecount1++;
                diecount2++;
                switch (Opt)
                {
                    case 1:
                        Console.WriteLine("Player choose No Play");
                        break;
                    case 2:
                        Console.WriteLine("Player got a Snake position will be decrease");
                        { if ((player1 - d1) < 0)
                            player1 = 0;
                        else
                            player1 -= d1;
                        }
                        {
                            if ((player2 - d2) < 0)
                                player2 = 0;
                            else
                                player2 -= d2;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player got a Ladder");
                        { if (player1 > 100)
                                player1 = player1;
                            else
                                player1 += d1;
                        }
                        {
                            if (player2 > 100)
                                player2 = player2;
                            else
                                player2 += d2;
                        }
                        break;
                }
                Console.WriteLine("player1 position " + player1);
                Console.WriteLine("player2 position " + player2);
                if (player1==100 || player2==100)
                {
                    if (player1 == 100)
                        Console.WriteLine("Player1 Won the game");
                    else if (player2 == 100)
                        Console.WriteLine("Player2 Won the game");
                }
                Console.WriteLine("No. of times Dice rolled by player is " + d1);
                Console.WriteLine("No. of times Dice rolled by player is " + d2);
            }
        }
    }
}

