using RxCookbook;
using System;

namespace RxExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dave = new Person();

            Dave.ObservePropertyChangedName().Dump("ObservePropertyChangedName");
            Dave.ObservePropertyChangedObject().Dump("ObservePropertyChangedObject");
            Dave.ObservePropertyChangedValue(d => d.Name).Dump("ObservePropertyChangedValue");            
            Dave.ObservePropertyChanged().Dump("ObservePropertyChanged");

            //Dave.ObservePropertyChangedName().Merge(Dave.ObservePropertyChangedName()).Dump("PropertyChangedName");

            Dave.Name = "Dave";
            Dave.Age = 21;
            Console.WriteLine("hello");



            Console.ReadKey();
        }
    }
}
