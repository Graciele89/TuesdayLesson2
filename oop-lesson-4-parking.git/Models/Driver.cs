using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.git.Models
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("Start Driver Class");
        }
        public void CreateClasses()
        {
            CarPark carpark = new CarPark();
            Console.WriteLine(carpark.ToString());

            Customer customer = new Customer("123C",3);
            Console.WriteLine(customer.ToString());

            carParkCharge carparkcharge = new carParkCharge();
            Console.WriteLine(carparkcharge.ToString());
        }

        public void populateCarPark()
        {
            Console.WriteLine("PopulateCarPark");
            CarPark carpark = new CarPark();

            Customer C1 = new Customer("123A",2);
            Customer C2 = new Customer("123B", 4);
            Customer C3 = new Customer("123C", 6);
            Customer C4 = new Customer("123D", 8);
            Customer C5 = new Customer("123E",10);

            carpark.listOfCustomers.Add(C1);
            carpark.listOfCustomers.Add(C2);
            carpark.listOfCustomers.Add(C3);
            carpark.listOfCustomers.Add(C4);
            carpark.listOfCustomers.Add(C5);

            carpark.CalculateCharges();
        }
     }
 }
