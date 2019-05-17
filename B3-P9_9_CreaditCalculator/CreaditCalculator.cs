using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_P9_9_CreaditCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита:");
            string creditstr = Console.ReadLine();
            int credit = Convert.ToInt32(creditstr);

            Console.WriteLine("Введите процент кредита:");
            string percentstr = Console.ReadLine();
            decimal percent = Convert.ToDecimal(percentstr);

            decimal payment;
            decimal balance = credit;
            decimal s =0;

            Console.WriteLine("Выплаты по месяцам:");
            for (int i = 0; i < 12; i++)
            {
                payment = credit / 12 + balance * percent / 100 / 12;
                Console.WriteLine($"{i+1} месяц: {Math.Round(payment, 2)} руб.");
                balance = balance - (decimal)credit / 12;
                //Console.WriteLine($"{Math.Round(balance, 2)}");
                s = s + payment;
            }
            Console.WriteLine($"Общая сумма выплат составит: {Math.Round(s, 2)} руб.");
            Console.ReadKey();
        }
    }
}
