using System;

namespace RandomDice
{
    class Program
    {
        public static int[] Rolldice(int dicenum)
        {
            Random diceRoller = new Random();
            int[] rolleddice = new int[dicenum];
            
            for (int i = 0; i < dicenum; i++)
            {
                rolleddice[i] = diceRoller.Next(1, 6);
            }

            return rolleddice;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Introduce the number of dices to roll");
            int diceNum = Convert.ToInt16(Console.ReadLine());

            int[] rolleddice = Rolldice(diceNum);

            foreach (int i in rolleddice)
            {
                Console.Write(i + " ");
            }
        }
    }
}