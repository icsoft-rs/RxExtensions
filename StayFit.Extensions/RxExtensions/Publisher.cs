using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StayFit.Extensions.RxExtensions
{
    public static class Publisher
    {
        public static int k = 0;

        public static IObservable<long> ObserveSeconds { get; }

        static Publisher()
        {
            ObserveSeconds = Observable.Create<long>(observer =>
            {
                Interlocked.Increment(ref k);
                //Console.WriteLine($"From ManagedThreadId {Thread.CurrentThread.ManagedThreadId} Observable started");
                //for (int i = 1; i < 11; i++)
                //{
                //    Thread.Sleep(2000);
                //    observer.OnNext(i);
                //}

                //Enumerable.Range(1, 10).ToList().ForEach(async x =>
                //{
                //    await Task.Delay(2000);
                //    observer.OnNext(x);
                //});

                Task.Run(async () =>
                {
                    Console.WriteLine($"From ManagedThreadId {Thread.CurrentThread.ManagedThreadId} Observable{k} started");
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

        public static Task<IEnumerable<int>> GetTask2()
        {

            return new Task<IEnumerable<int>>((() =>
            {
                return Enumerable.Range(1, 10);
            }));
        }

        public static Task<IEnumerable<int>> GetTask3()
        {

            return Task.Run((() =>
            {
                return Enumerable.Range(1, 10);
            }));
        }

        public static Task<Stack<int>> GetTask()
        {
            return Task.Run((async () =>
            {
                Stack<int> stack = new Stack<int>();
                Console.WriteLine($"From ManagedThreadId {Thread.CurrentThread.ManagedThreadId} Task created");
                for (int i = 1; i < 11; i++)
                {
                    stack.Push(i);
                    await Task.Delay(2000);
                }

                return stack;                
            }));
        }
    }
}
