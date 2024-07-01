using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cars cars = new cars("car1",2022, "Sedan",22222,"M5",123456,"black",false);
            Console.WriteLine(cars.GetFullInfo());
            Bmw bmw=new Bmw("car1", 2022, "Sedan", 22222, "M5", 123456, "black", false, "6 Series");
            Console.WriteLine(bmw.Getfullinfo("6 Series"));
            bmw.Start();
            bmw.Stop();
           
        }
    }
}
