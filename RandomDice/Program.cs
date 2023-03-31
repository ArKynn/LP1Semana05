using System;

namespace RandomDice
{
    class Program
    {
        public static int Rolldice()
        {
            int rolleddice = 0;
            Random diceRoller = new Random();

            rolleddice = diceRoller.Next(1, 7);
            
            return rolleddice;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Introduce the number of dices to roll");
            int diceNum = Convert.ToInt16(Console.ReadLine());

            int valueSum = 0;
            int rolledValue = 0;

            for (int i = 0; i < diceNum; i++)
            {
                rolledValue = Rolldice();
                Console.Write(rolledValue + " ");

                valueSum += rolledValue;

            }
            Console.WriteLine($"\nSum of dice values = {valueSum}");
        }
    }
}