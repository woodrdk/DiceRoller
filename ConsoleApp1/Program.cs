using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();
            Die dice4 = new Die();
            Die dice5 = new Die();
            

            Console.WriteLine(dice1.Value);
            Console.WriteLine(dice2.Value);
            Console.WriteLine(dice3.Value);
            Console.WriteLine(dice4.Value);
            Console.WriteLine(dice5.Value);

            Console.WriteLine();

            Die[] dice = new Die[5];
            // create the dice

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }


            // roll the dice

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
                Console.WriteLine(dice[i].Value);
            }
            Console.ReadKey();
        }
    }
}
