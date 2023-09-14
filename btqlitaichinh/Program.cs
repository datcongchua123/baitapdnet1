using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tai Khoan Ca Nhan");
        Console.Write("Moi ban nhap ten: ");
        String ten = Console.ReadLine();
        Console.Write("Nhap so tien trong tai khoan: ");
        int tien = Convert.ToInt32(Console.ReadLine());
        while (tien < 0)
        {
            if (tien < 0)
            {
                Console.WriteLine("SO TIEN KHONG HOP LE !");
                break;
            }
        }
        Console.WriteLine("Ban hay nhap cac giao dich trong thang");
        int n = 1;
        int tientk = 0;
        while (tien > 0)
        {
            Console.Write("Giao dich" + n + ":");
            int tiengd = Convert.ToInt32(Console.ReadLine());
            tientk += tiengd;
            n++;
            if (tiengd == -1)
            {
                break;
            }
            tien = tien - tientk; tientk = -1;
            Console.WriteLine("So tien con lai cua " + ten + " la:");
            Console.WriteLine("So tien con lai: " + tien);
        }
    }
}