namespace HelloWorld;

using System;
using System.Globalization;
using System.Threading;

class Program2
{
    static void test(string[] args)
    {
        // Tarih ve saat değerini bir dize olarak tanımla
        string var_str_Date;

        // Tarih/saat nesnesini oluştur
        DateTime var_datetime_Date = new DateTime(2023, 05, 13, 23, 55, 30);

        // Tarih/saat nesnesini dizeye dönüştür ve yazdır
        var_str_Date = var_datetime_Date.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine(var_str_Date);

        // Tarih/saat nesnesinin gün ve ay adlarını Türkçe olarak yazdır
        var_str_Date = var_datetime_Date.ToString("dddd dd MMMM yyyy HH:mm:ss", CultureInfo.GetCultureInfo("tr-TR"));
        Console.WriteLine(var_str_Date);

        // Çıktı :

        // 13.05.2023 23:55:30
        // Cumartesi 13 Mayıs 2023 23:55:30
    }
}
