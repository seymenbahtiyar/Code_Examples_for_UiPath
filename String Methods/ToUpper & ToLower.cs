namespace HelloWorld;

using System;
using System.Globalization;

class Program6
{
    static void test(string[] args)
    {
        string toupper;
        string tolower;

        // Assigning Turkish characters to toupper and tolower strings
        toupper = "iıçğöşü";
        tolower = "İIÇĞÖŞÜ";
        
        // Converting toupper string to uppercase using Turkish culture
        toupper = toupper.ToUpper(new System.Globalization.CultureInfo("tr-TR", false));

        // Converting tolower string to lowercase using Turkish culture
        tolower = tolower.ToLower(new System.Globalization.CultureInfo("tr-TR", false));

        // Printing the results
        Console.WriteLine("Türkçe ToUpper : " + toupper);
        Console.WriteLine("Türkçe ToLower : " + tolower);
    }
}
