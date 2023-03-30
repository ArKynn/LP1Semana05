using System;
using System.Diagnostics;

namespace Tempo
{
    class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            
            crono1.Start();
            Thread.Sleep(500);
            
            crono2.Start();
            Thread.Sleep(300);
            
            crono1.Stop();
            crono2.Stop();

            double crono1_time = Convert.ToDouble(crono1.ElapsedMilliseconds) / 100;
            double crono2_time = Convert.ToDouble(crono2.ElapsedMilliseconds) / 100;
            
            Console.WriteLine($"Crono1 = {crono1_time}s");
            Console.WriteLine($"Crono2 = {crono2_time}s");
        }    
    }
    
}
