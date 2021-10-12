using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.git.Models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public carParkCharge carParkcharge = new carParkCharge();

        public CarPark()
        {
            Console.WriteLine("Starting carpark class");
        }

        public override string ToString()
        {
            return "______________CarPark";
        }

        public void CalculateCharges()
        {
            foreach(Customer currentCustomer in listOfCustomers)
            {
                int calculatedCharges = carParkCharge.calculatedCharges(currentCustomer.hoursParked);

                Console.WriteLine($"Calculating charges for {currentCustomer.carRegistration} : {currentCustomer.hoursParked} hoursnparked costs {calculatedCharges}");
            }
        }
    }
 }
