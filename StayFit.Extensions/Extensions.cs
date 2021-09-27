using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StayFit.Extensions
{
    public static class Extensions
    {
        public static void WriteLineColored(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"From ManagedThreadId {Thread.CurrentThread.ManagedThreadId} => {message}");
        }
    }
}
