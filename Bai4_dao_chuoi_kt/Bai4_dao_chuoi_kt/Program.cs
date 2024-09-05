using System;


class program
{
    static void Main()
    {
        Console.WriteLine("Bai 4 Dao chuoi ki tu");
        Console.WriteLine("nhap chuoi ki tu: ");
        string chuoi=Console.ReadLine();
        string chuoidao="";
        for(int i = chuoi.Length - 1; i >=0; i--)
        {
            chuoidao += chuoi[i];
        }
        Console.WriteLine($"chuoi sau khi dao la: {chuoidao}");
        Console.WriteLine(chuoidao);
    }
}
