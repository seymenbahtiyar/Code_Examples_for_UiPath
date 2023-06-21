namespace HelloWorld;

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void test(string[] args)
    {
        // Kültürü ayarla
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

        // Tarih ve saat değerini bir dize olarak tanımla
        string var_str_Date = "13.05.2023 23:55:30";

        // Dizeyi tarih/saat nesnesine dönüştür
        DateTime var_datetime_Date = DateTime.ParseExact(var_str_Date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        // Tarih/saat nesnesini yazdır
        Console.WriteLine("Sistem Tarih Formatı : " + var_datetime_Date.ToString());

        // Tarih/saat nesnesinin gün ve ay adlarını yazdır
        Console.WriteLine("Gün ve Ay Adları : " + var_datetime_Date.ToString("dddd MMMM", CultureInfo.GetCultureInfo("tr-TR")));

        // Mevcut kültür bilgilerini yazdır
        CultureInfo MevcutKultur = Thread.CurrentThread.CurrentCulture;
        Console.WriteLine($@"Kültür Kodu : {MevcutKultur.Name}");
        Console.WriteLine($@"Kültür : {MevcutKultur.DisplayName}");
        Console.WriteLine($@"İngilizce Adı : {MevcutKultur.EnglishName}");
        Console.WriteLine($@"Tarih Formatı : {MevcutKultur.DateTimeFormat.DateSeparator}(Tarih) ve {MevcutKultur.DateTimeFormat.TimeSeparator}(Zaman)");
        Console.WriteLine($@"Numara Ayırıcı : {MevcutKultur.NumberFormat.NumberDecimalSeparator}");

        // Çıktı:

        // Sistem Tarih Formatı : 13.05.2023 23:55:30
        // Gün ve Ay Adları : Cumartesi Mayıs

        // Kültür Kodu : tr-TR
        // Kültür : Türkçe (Türkiye)
        // İngilizce Adı : Turkish (Turkey)
        // Tarih Formatı : .(Tarih) ve :(Zaman)
        // Numara Ayırıcı : ,
    }
}
