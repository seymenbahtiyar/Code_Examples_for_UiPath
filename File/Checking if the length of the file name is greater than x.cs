namespace HelloWorld;

using System;
using System.Globalization;
using System.IO;

class Program7
{
    static void Main(string[] args)
    {
        // Assigning a file name to the fileName variable
        string fileName = "exampleeeeeeeeeeeeeee.txt";
        
        // Getting the file name without the extension
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

        // Checking if the length of the file name without extension is greater than 10
        if (fileNameWithoutExtension.Length > 10)
        {
            // Truncating the file name without extension to 10 characters
            fileNameWithoutExtension = fileNameWithoutExtension.Substring(0, 10);
        }

        // Creating a new file name by adding the .txt extension to the truncated file name
        string newFileName = fileNameWithoutExtension + ".txt";

        // Printing the new file name
        Console.WriteLine(newFileName);
    }
}
