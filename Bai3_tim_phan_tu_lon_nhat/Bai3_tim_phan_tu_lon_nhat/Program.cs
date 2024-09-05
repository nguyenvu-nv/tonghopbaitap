using System;


class program
{
    static void Main()
    {
        Console.WriteLine("Bai 3 tim phan tu lon nhat");
        Console.WriteLine("nhap so luong phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        int max = mang[0];
        for(int i = 1; i < n; i++)
        {
            if (max < mang[i])
            {
                max= mang[i];
            }
        }
        Console.WriteLine($"phan tu lon nhat trong mang la: {max}");
    }
}

