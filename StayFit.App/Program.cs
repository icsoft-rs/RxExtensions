using StayFit.Extensions.RxExtensions;
using System;
using System.Threading;
using StayFit.Extensions;

namespace StayFit.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var observer = Publisher.ObserveSeconds.Subscribe(x => StayFit.Extensions.Extensions.WriteLineColored($"{x}", ConsoleColor.Yellow));
            Thread.Sleep(5000);
            var observer2 = Publisher.ObserveSeconds.Subscribe(x => StayFit.Extensions.Extensions.WriteLineColored($"{x}", ConsoleColor.Green));
            
            
            Console.WriteLine("UI wait here");
            Console.ReadKey();
        }
    }
}
