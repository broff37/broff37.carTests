using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Создаем двигатели
            Engine engineFirst = new EngineUAZ("Двигатель №1",0);
            Engine engineSecond = new EngineUAZ("Двигатель №2",-1);
            Engine engineThird = new EngineUAZ("Двигатель №3",50);
            //Создаем машины
            Car carFirst = new Car("Nissan", engineFirst);
            Car carSecond = new Car("BMW", engineSecond);
            Car carThird = new Car("Lexus", engineThird);
            //Создаем тестировщика
            Tester tester = new Tester("Тестер №1");
            //Тесты
            Console.WriteLine("\n\tТест №1");
            tester.Test(carFirst);
            Console.WriteLine("\n\tТест №2");
            tester.Test(carSecond);
            Console.WriteLine("\n\tТест №3");
            tester.Test(carThird);

            Console.ReadKey();
        }
    }
}
