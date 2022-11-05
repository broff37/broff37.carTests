using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace CarsTest
{
    public class Car 
    {
        public string Name { get; set; }
        public Engine EngineCar;

        public Car(string name, Engine engine)
        {
            Name = name;
            EngineCar = engine;
        }

        public void Test()
        {
            Start();
        }

        public void Start()
        {
            if (EngineCar.AmountGas == 0)
            {
                throw new CarException("Двигатель не работает", DateTime.Now);
            }
            else
            {
                Console.WriteLine($"\tМашина: {Name} с двигателем: {EngineCar.Name} заведена, количество бензина: {EngineCar.AmountGas} литров");
            }
        }
    }
}
