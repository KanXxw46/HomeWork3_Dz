using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace HomeWork3_DZ
{
    class Program
    {
        //Task 2
        static void Main(string[] args)
        {
            Console.WriteLine("Введдите 6 значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string strNumber = number.ToString();
            if(strNumber.Length != 6)
            {
                Console.WriteLine("В билете должно быть только 6 цифр");
            }
            //Task 3
            
            Console.WriteLine("Ввеите строку:");
            string str = Console.ReadLine();
            string _Str = null;
            for(int i = 0; i < str.Length; i++)
            {
            if (Convert.ToInt32(str[i]) >= 60 & Convert.ToInt32(str[i]) <= 90){
                    _Str += Convert.ToChar(Convert.ToInt32(str[i]) + 32);
            }
                else
                {
                    _Str += Convert.ToChar(Convert.ToInt32(str[i]) - 32);
                }
            }
            // Task 4 
            int A, B;
            Console.WriteLine("A>B: ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            for(int i = B; i <= A; i++)
            {
                for (int j = 0;j< i; j++)
                {
                    Console.WriteLine($"{j}");
                }
                Console.WriteLine();
            }
            //Task 5 
            int N;
            Console.WriteLine(" N>0: ");
            N = Convert.ToInt32(Console.ReadLine());
            string tmp = Convert.ToString(N);
            string Number = null;

            for (int i = tmp.Length - 1; i >0; i--)
            {
                Number += tmp[i];
            }
            Console.WriteLine(Number);

        }

    }
}