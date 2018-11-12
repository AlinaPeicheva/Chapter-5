using System;


class Program
{
    static void Main()
    {
        /* Да се напише if конструкция, която проверява стойността на две целочислени променливи и 
           разменя техните стойности, ако стойността на първата променлива е по-голяма от втората. */

        Console.Write("Въведете първото число ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Въведете второто число ");
        int b = int.Parse(Console.ReadLine());

        int c = a;
        Console.WriteLine("A : {0}  ||  B : {1}", a, b);

        if (a > b)
        {
            a = b;
            b = c;
            Console.WriteLine("A new = {0}  ||  B new = {1}", a, b);
        }
        else
        {
            Console.WriteLine("Няма изменения");
        }
    }
    
}

