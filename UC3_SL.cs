using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC3_SL
    {
        public static void Option()
        {
            Random die = new Random();
            int a = die.Next(1, 7);
            Console.WriteLine("Dice obtain is " + a);
            int position = 0;
            Random option = new Random();
            int Opt = option.Next(1, 4);
                switch (Opt)
                {
                    case 1:
                        Console.WriteLine("Player choose No Play");
                        break;
                    case 2:
                        Console.WriteLine("Player got a Snake position will be decrease");
                        if ((position -a) < 0)
                            position = 0;
                        else
                            position =position- a;
                        break;
                    case 3:
                        Console.WriteLine("Player got a Ladder");
                    if (position > 100)
                        position = position;
                    else
                        position = position + a;
                    break;
            }
                Console.WriteLine("player position " + position);
            }
        }
    }
