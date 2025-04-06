using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consumption, cost;
            // دریافت میزان مصرف برق از کاربر
            Console.WriteLine(" Please enter the electricity consumption in kilowatts : ");
            consumption = int.Parse(Console.ReadLine());

            // محاسبه هزینه برق مصرفی
            cost = 0;

            if (consumption <= 5)
            {
                cost = 0; // Free
            }
            else if (consumption > 5 && consumption <= 20)
            {
                cost = (consumption - 5) * 1000; // Each kilowatt in excess of 5, 1000 Tomans
            }
            else if (consumption > 20)
            {
                cost = (15 * 1000) + ((consumption - 20) * 5000); // Cost up to 20 kW and above 20 kW
            }

            // اضافه کردن آبونمان
            cost += 10000;

            // نمایش نتیجه
            Console.WriteLine($" Your electricity cost is: {cost} Tomans.");
            Console.ReadKey();
        }
    }
}
