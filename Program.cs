using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = "Число римскими цифрами: ";
            while (a >= 1000) 
            {
                b = b + "M";
                a = a - 1000;
            }
            while (a >= 500)
            {
                b = b + "D";
                a = a - 500;
            }
            while (a >= 400)
            {
                b = b + "CD";
                a = a - 400;
            }
            while (a >= 100)
            {
                b = b + "C";
                a = a - 100;
            }
            while (a >= 10)
            {
                b = b + "X";
                a = a - 10;
            }
            while (a >= 9)
            {
                b = b + "IX";
                a = a - 10;
            }
            while (a >= 5)
            {
                b = b + "V";
                a = a - 5;
            }
            while (a >= 4)
            {
                b = b + "IV";
                a = a - 4;
            }
            while (a >= 1)
            {
                b = b + "I";
                a = a - 1;
            }
            Console.WriteLine(b);
        }
    }
}
