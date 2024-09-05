using System;

class program
{
    static void Main()
    {
        Console.WriteLine("nhap mang sau");
        Console.Write("nhap so phan tu");
        int n=int.Parse(Console.ReadLine());
        int[] number = new int[n];
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write($"nhap phan tu thu {i+1}: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("mang da nhap la:");
        foreach (int i in number) 
        {
            Console.WriteLine($" {i}");
        }
        int numbermax = number[0];
        foreach (int i in number)
        {
            if (numbermax < i)
            {
                numbermax = i;
            }
        }
        Console.WriteLine($"so lon nhat trong mang la: {numbermax}");
    }
}