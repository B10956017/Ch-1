using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_precent = 15;
            int tax_precent = 8;
            double realtax_precent = (int)tax_precent*0.1;
            int count = 0;
            int total = 0;
            count = (int)((meal_cost + tip_precent) * realtax_precent);
            total = (int)(count + tip_precent + meal_cost);
            Console.WriteLine("用餐費用為:" + meal_cost);
            Console.WriteLine("服務費為:" + tip_precent);
            Console.WriteLine("稅率為:" + tax_precent);
            Console.WriteLine("總用餐費用為:" + total);
        }
    }
}
