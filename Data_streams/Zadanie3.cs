using System;
using System.IO;
using System.Text;

public class Zadanie3
{
    public static void Run()
    {
        string path = @"plik.txt";

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);

            string zawartosc = Encoding.UTF8.GetString(bytes);
            Console.WriteLine("Zawartość pliku:");
            Console.WriteLine(zawartosc);
        }
    }
}

