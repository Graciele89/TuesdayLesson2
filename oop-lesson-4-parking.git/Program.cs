using oop_lesson_4_parking;
using System;

namespace oop_lesson_4_parking.git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************** Parking Application ****************");

            Driver driver = new Driver();

            driver.CreateClasses();
            driver.PopulateCarPark();
        }
    }
}
           