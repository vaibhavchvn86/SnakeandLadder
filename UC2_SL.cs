using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class UC2_SL
    {
        public static void Dice()
        {
            Random die = new Random();
            int Dice = die.Next(1, 7);
            Console.WriteLine("Dice obtain is "+Dice);
        }
    }
}
