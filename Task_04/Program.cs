﻿using System;


class Program
{
    static void Main()
    {
        // Сортирайте 3 реални числа в намаляващ ред.Използвайте вложени if оператори

        Console.Write("Въведете първото число: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете второто число: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете третето число: ");
        int c = Int32.Parse(Console.ReadLine());
        

        if (a < b)
        {
            if (a < c)
            {
                a = a + c;
                c = a - c;
                a = a - c;

                if (b > c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a >= c)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
        }
        else if (a == b)
        {
            if (a < c)
            {
                a = a + c;
                c = a - c;
                a = a - c;
            }
        }
        else
        {
            if (b < c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
        }
        Console.WriteLine("{0}, {1}, {2}", a, b, c);
        Console.ReadLine();
    }
}

