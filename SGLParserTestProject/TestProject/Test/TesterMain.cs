using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Test
{
    class TesterMain
    {
        static void Main(string[] args)
        {
            Car audi = new Car(1995);
            Singleton singleton = Singleton.Instance;
            singleton.AddCar(audi);

            audi.year = 2001;
            Console.WriteLine("this class year: " + audi.year + " and singleton car year: " + Singleton.Instance.PrintFirstCarYear());
            Console.ReadLine();
        }
    }
}
