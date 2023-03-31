using System;
using System.Text;

namespace LowerUnion
{
    class Program
    {
        private static void Main(string[] args)
        {
            Array.Sort(args);
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < args.Length; i++)
            {
                output.Append((args[i].ToLower()));
                if (i != args.Length - 1)
                {
                    output.Append('_');
                }
            }
            Console.WriteLine($"Rearranged string: {output}");
        }
    }
}