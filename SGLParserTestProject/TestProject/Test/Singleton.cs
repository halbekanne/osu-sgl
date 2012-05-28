using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Test
{
    class Singleton
    {

        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        private List<Car> cars = new List<Car>();

        public void AddCar(Car c)
        {
            cars.Add(c);
        }

        public String PrintFirstCarYear()
        {
            return cars[0].year.ToString();
        }
    }
}
