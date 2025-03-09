using System;
using System.IO;

public class Zadanie6
{
    public static void Run()
    {
        string sourcePath = @"C:\sciezka\plik1.txt";
        string destPath = @"C:\sciezka\plik2.txt";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Plik źródłowy nie istnieje.");
            return;
        }

        using (FileStream source = new FileStream(sourcePath, FileMode.Open))
        using (FileStream destination = new FileStream(destPath, FileMode.Create))
        {
            source.CopyTo(destination);
        }

        Console.WriteLine("Kopiowanie zakończone sukcesem.");
    }
}

