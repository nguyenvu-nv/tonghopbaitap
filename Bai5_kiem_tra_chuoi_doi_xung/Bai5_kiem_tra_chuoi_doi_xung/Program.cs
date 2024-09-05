using System;
using System.Text;


class program
{
    static void Main()
    {
        Console.WriteLine("Bai 5 kiem tra mang doi xung");
        Console.WriteLine("nhap so luong phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        bool kt=true;
        for (int i = 0; i <=(n-1)/2; i++)
        {
            if (mang[i] != mang[n-1-i])
            {
                kt = !kt;break;
            }
        }
        if (kt)
        {
            Console.WriteLine($"mang doi xung");
        }
        else
        {
            Console.WriteLine("mang khong doi xung");
        }
    }
}

