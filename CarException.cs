using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTest
{
    public class CarException : Exception
    {
        public DateTime dateTime { get; }
        public CarException(string message, DateTime datetime)
            : base(message)
        {
            dateTime = datetime;
        }
    }
}
