using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Bai 2 dem so phan tu trong chuoi");
        Console.WriteLine("nhap chuoi ki tu");
        string chuoi = Console.ReadLine();
        int dem = 0;
        char a;
        for (int i = 0; i < chuoi.Length; i++)
        {
            a = chuoi[i];
            if (!char.IsWhiteSpace(a) && !char.IsPunctuation(a))
            {
                dem++;
            }
        }
        Console.WriteLine($"so phan tu cua chuoi khong tinh space va dau la: {dem}");
    }
}
