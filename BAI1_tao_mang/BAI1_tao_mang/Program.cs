using System;


class program
{
    static void Main()
    {
        Console.WriteLine("Bai 1 tao mang va tinh tong cac phan tu trong mang");
        Console.WriteLine("nhap so luong phan tu cho mang: ");
        int n= int.Parse(Console.ReadLine());
        int[] mang= new int[n];
        int tong = 0;
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap phan tu thu {i+1}: ");
            mang[i] = int.Parse(Console.ReadLine());
            tong+=mang[i];
        }
        Console.WriteLine($"tong cac phan tu cua mang la: {tong}");
    }
}
