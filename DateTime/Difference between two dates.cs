namespace HelloWorld;

using System;
using System.Globalization;
using System.Threading;

class Program3
{
    static void test(string[] args)
    {
        // İki tarih/saat nesnesi oluştur
        DateTime date1 = new DateTime(2023, 6, 13, 18, 0, 0);
        DateTime date2 = new DateTime(2023, 6, 10, 12, 30, 0);

        // İki tarih/saat nesnesi arasındaki farkı hesapla
        TimeSpan difference = date2 - date1;

        // Gün farkını yazdır
        Console.WriteLine("Gün farkı: " + Math.Abs(difference.Days));

        // Saat farkını yazdır
        Console.WriteLine("Saat farkı: " + Math.Abs(difference.Hours));

        // Dakika farkını yazdır
        Console.WriteLine("Dakika farkı: " + Math.Abs(difference.Minutes));

        // Saniye farkını yazdır
        Console.WriteLine("Saniye farkı: " + Math.Abs(difference.Seconds));

        // Toplam gün farkını yazdır
        Console.WriteLine("Toplam gün farkı: " + Math.Abs(difference.TotalDays));

        // Toplam saat farkını yazdır
        Console.WriteLine("Toplam saat farkı: " + Math.Abs(difference.TotalHours));

        // Toplam dakika farkını yazdır
        Console.WriteLine("Toplam dakika farkı: " + Math.Abs(difference.TotalMinutes));

        // Toplam saniye farkını yazdır
        Console.WriteLine("Toplam saniye farkı: " + Math.Abs(difference.TotalSeconds));

        // Çıktı :

        // Gün farkı: 3
        // Saat farkı: 5
        // Dakika farkı: 30
        // Saniye farkı: 0

        // Toplam gün farkı: 3,2291666666666665
        // Toplam saat farkı: 77,5
        // Toplam dakika farkı: 4650
        // Toplam saniye farkı: 279000
    }
}
