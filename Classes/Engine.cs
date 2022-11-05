using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTest
{
    abstract public class Engine
    {
        public string Name { get; set; }
        private int amount;
        public int AmountGas
        {
            get
            {
                return amount;
            }
            protected set
            {
                if (value < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount = value;
                }
            }
        }
        public Engine(string name, int amountGas)
        {
            Name = name;
            AmountGas = amountGas;
        }
    }
}
