using RxCookbook;
using System;

namespace RxExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dave = new Person();

            //Dave.PropertyChangedName().Dump("PropertyChangedName");
            //Dave.PropertyChangedObject().Dump("PropertyChangedObject");
            //Dave.PropertyChangedValue(d => d.Name).Dump("PropertyChangedValue");
            //Dave.PropertyChangedName().Merge(Dave.PropertyChangedName()).Dump("PropertyChangedName");
            Dave.ObservePropertyChanged().Dump("ObservePropertyChanged");

            Dave.Name = "Dave";
            Dave.Age = 21;
            Console.WriteLine("hello");



            Console.ReadKey();
        }
    }
}
