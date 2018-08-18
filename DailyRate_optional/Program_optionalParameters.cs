using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate_optional
{
    class Program_optionalParameters

    {
        static void Main(string[] args)
        {
            (new Program_optionalParameters()).run();
        }

        void run()
        {
            double fee = calculateFee(500);
            Console.WriteLine($"Fee is {fee}");
        }
        private double calculateFee(double theDailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            return theDailyRate * noOfDays;
        }

        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using one optional parameter for a single day");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double calculateFee()
        {
            Console.WriteLine("calculateFee using hardcoded values");
            int defaultNoOfDays = 1;
            double defaultDailyRate = 400.0;
            return defaultDailyRate * defaultNoOfDays;
        }
    }
}