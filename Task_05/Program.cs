using System;

class Program
{
    static void Main()
    {
        /*Напишете програма, която за дадена цифра (0-9), зададена като вход,
        извежда името на цифрата на английски език. Използвайте switch конструкция.*/

        Console.Write("Въведете число (0-9): ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: Console.WriteLine("Wrong input"); break;


        }
    }
}

