using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTest
{
    public class Tester
    {
        public string Name { get; set; }
        public Tester(string name)
        {
            Name = name;
        }

        public void Test(Car car)
        {
            try
            {
                car.Test();
            }
            catch (CarException ex)
            {
                Console.WriteLine($"\t Ошибка: {ex.Message}");
                Console.WriteLine($"\t Время теста: {ex.dateTime}");
                Console.WriteLine($"\t Название двигателя: {car.EngineCar.Name}");
                Console.WriteLine($"\t Количество бензина в двигателе: {car.EngineCar.AmountGas}");
            }
        }
    }
}
