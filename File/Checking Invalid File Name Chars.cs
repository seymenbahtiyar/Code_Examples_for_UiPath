namespace HelloWorld;

using System;
using System.Globalization;
using System.Threading;
using System.IO;

class Program5
{
    static void test(string[] args)
    {
        // Bir dosya adı oluşturmak için geçersiz karakterleri içeren bir değişken tanımlayın
        string fileNameWithoutExtension = "test:file*name?";

        // Geçersiz karakterleri alt çizgi ile değiştirin
        fileNameWithoutExtension = String.Join("_", fileNameWithoutExtension.Split(System.IO.Path.GetInvalidFileNameChars()));

        // Sonucu konsola yazdırın
        Console.WriteLine(fileNameWithoutExtension);

        // Output : 

        // test_file_name_
    }
}
