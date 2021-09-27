using StayFit.Extensions.RxExtensions;
using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading;

namespace StayFit.App
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("App started.");
            Console.WriteLine($"App ManagedThreadId {Thread.CurrentThread.ManagedThreadId}");
            MainAsync().Wait();           
            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            var observer = Publisher.ObserveSeconds;
            observer.Where(i => i > 5).Subscribe(x => Extensions.Extensions.WriteLineColored($"Observer {x}", ConsoleColor.Cyan));
            observer.Subscribe(x => Extensions.Extensions.WriteLineColored($"Observer {x}", ConsoleColor.Yellow));
            await Task.Delay(TimeSpan.FromSeconds(5));
            var observer2 = Publisher.ObserveSeconds.Subscribe(x => Extensions.Extensions.WriteLineColored($"Observer {x}", ConsoleColor.Green));            
        }
    }
}
