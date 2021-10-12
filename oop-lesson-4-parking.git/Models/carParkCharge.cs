using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.git.Models
{
    public class carParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public carParkCharge(int _minimumFee=2, int _minimumHours = 3)
        {
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
            Console.WriteLine("Starting CarParkCharge class");
        }
        public override string ToString()
        {
            return "_________________________carkParkCharge";
        }
        public int calculatedCharges(int hoursParked)   //calculate charge
        {
            int minimumFee = 2;
            return hoursParked * minimumFee;
        }
    }
}             //not finished
