using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Threading;
using System.Threading.Tasks;

namespace StayFit.Extensions.RxExtensions
{
    public static class Publisher
    {
        public static IObservable<long> ObserveSeconds { get; }

        static Publisher() 
        {
            ObserveSeconds = Observable.Create<long>(observer =>
            {
                Task.Run(async () =>
                {
                    Console.WriteLine($"From ManagedThreadId {Thread.CurrentThread.ManagedThreadId} Observable started");
                    for (int i = 1; i < 11; i++) 
                    {
                        await Task.Delay(2000);
                        observer.OnNext(i);
                    }
                    
                    //Enumerable.Range(1, 10).ToList().ForEach(async x =>
                    //{
                    //    await Task.Delay(2000);
                    //    observer.OnNext(x);
                    //});
                });
                

                return Disposable.Empty;
            });
        }
    }
}
