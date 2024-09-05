

using System;

class Program
{
    static void Main()
    {
        Console.Write("nhap so ban doan: ");
        int number1= int.Parse(Console.ReadLine());
        Random random = new Random();
        int number2 = random.Next(1, 6);
        if (number1.CompareTo(number2) == 0)
        {
            Console.WriteLine("ban da doan dung");
            Console.WriteLine($"so cua toi la: {number2}");
        }
        else
        {
            Console.WriteLine("ban da doan sai");
            Console.WriteLine($"so cua toi la: {number2}");
        }

    }
}