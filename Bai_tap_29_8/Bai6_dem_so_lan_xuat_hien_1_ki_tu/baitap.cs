using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_hop_BT;

class baitap
{
    public void Bai1()
    {
        Console.WriteLine("Bai 1 tao mang va tinh tong cac phan tu trong mang");
        Console.WriteLine("nhap so luong phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
            tong += mang[i];
        }
        Console.WriteLine($"tong cac phan tu cua mang la: {tong}");
    }
    public void Bai2()
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
    public void Bai3()
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
        for (int i = 1; i < n; i++)
        {
            if (max < mang[i])
            {
                max = mang[i];
            }
        }
        Console.WriteLine($"phan tu lon nhat trong mang la: {max}");
    }
    public void Bai4()
    {
        Console.WriteLine("Bai 4 Dao chuoi ki tu");
        Console.WriteLine("nhap chuoi ki tu: ");
        string chuoi = Console.ReadLine();
        string chuoidao = "";
        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            chuoidao += chuoi[i];
        }
        Console.WriteLine($"chuoi sau khi dao la: {chuoidao}");
        Console.WriteLine(chuoidao);
    }
    public void Bai5()
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
        bool kt = true;
        for (int i = 0; i <= (n - 1) / 2; i++)
        {
            if (mang[i] != mang[n - 1 - i])
            {
                kt = !kt; break;
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
    public void Bai6()
    {
        Console.WriteLine("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        Console.WriteLine("nhap ki tu can dem: ");
        char kyTu = Console.ReadLine()[0];
        int dem = 0;
        for (int i = 0; i < chuoi.Length; i++)
        {
            if (chuoi[i] == kyTu)
            {
                dem++;
            }
        }
        Console.WriteLine($"So lan xuat hien cua ki tu '{kyTu}' trong chuoi la: {dem}");
    }
}
