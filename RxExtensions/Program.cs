using RxCookbook;
using System;
using System.Reactive.Linq;
using System.Threading;

namespace RxExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stream = Publisher.ObserveSeconds;
            var observer = Publisher.ObserveSeconds.Subscribe(x => WriteLineColored($"{x}", ConsoleColor.Yellow));
            Thread.Sleep(5000);
            var observer2 = Publisher.ObserveSeconds.Subscribe(x => WriteLineColored($"{x}", ConsoleColor.Green));
            //var observer2 = Publisher.ObserveSeconds.Replay();
            //observer2.Connect();
            //observer2.Subscribe(x => WriteLineColored($"{x}", ConsoleColor.Green));
            //var period = TimeSpan.FromSeconds(1);
            //var hot = Observable.Interval(period)
            //.Take(3)
            //.Publish();
            //hot.Connect();
            //Thread.Sleep(period); //Run hot and ensure a value is lost.
            //var observable = hot.Replay();
            //observable.Connect();
            //observable.Subscribe(i => Console.WriteLine("first subscription : {0}", i));
            //Thread.Sleep(period);
            //observable.Subscribe(i => Console.WriteLine("second subscription : {0}", i));
            //Console.ReadKey();
            //observable.Subscribe(i => Console.WriteLine("third subscription : {0}", i));
            //Console.ReadKey();

            //var hot = Observable.Interval(TimeSpan.FromSeconds(2)).Take(10).Publish();
            //hot.Connect();

            //var observable = hot.Replay();


            ////var observer1 = hot.Subscribe(x => WriteLineColored($"Observer {x}", ConsoleColor.Red));
            //Thread.Sleep(5000);

            //observable.Connect();
            //observable.Subscribe(x => WriteLineColored($"Observer {x}", ConsoleColor.Green));


            //var Dave = new Person();

            //Dave.ObservePropertyChangedName().Dump("ObservePropertyChangedName");
            //Dave.ObservePropertyChangedObject().Dump("ObservePropertyChangedObject");
            //Dave.ObservePropertyChangedValue(d => d.Name).Dump("ObservePropertyChangedValue");            
            //Dave.ObservePropertyChanged().Dump("ObservePropertyChanged");

            ////Dave.ObservePropertyChangedName().Merge(Dave.ObservePropertyChangedName()).Dump("PropertyChangedName");

            //Dave.Name = "Dave";
            //Dave.Age = 21;
            Console.WriteLine("Ending...");



            Console.ReadKey();
        }

        static void WriteLineColored(string message, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
