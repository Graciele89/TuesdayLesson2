using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.git.Models
{
    public class Customer
    {
        public string carRegistration { get; set;}
        public int hoursParked { get; set; }
        public Customer(string _carRegistration, int _hoursParked)

        {
            carRegistration = _carRegistration;
            hoursParked = _hoursParked;
            Console.WriteLine("Starting Customer Class");
        }
        public override string ToString()
        {
            return $"_______________CustomerClass{carRegistration} : {hoursParked}";
        }

    }
}
