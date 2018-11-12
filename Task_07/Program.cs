using System;

class Program
    {
        static void Main()
        {
        // Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.

            Console.Write("Въведете първото число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведете второто число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Въведете третето число: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Въведете четвертото число: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Въведете петото число: ");
            int e = int.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} is the biggest.", a);
        else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} is the biggest.", b);
        else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} is the biggest.", c);
        else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} is the biggest.", d);
        else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} is the biggest.", e);
        else Console.WriteLine("There isn't a biggest number.");


    }
    }

