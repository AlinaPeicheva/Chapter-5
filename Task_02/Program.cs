using System;


class Program
{
    static void Main()
    {
        /*Напишете програма, която показва знака (+ или -) от произведението на три реални числа, без да го пресмята.
          Използвайте последователност от if оператори.*/
        Console.Write("Въведете първото число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Въведете второто число: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Въведете третето число: ");
        int c = int.Parse(Console.ReadLine());
        

             if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");
        else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");
        else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");
        else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");
        else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");
        else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");
        else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");
        else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");
        
    }
}

