using System;
using System.Diagnostics;
using System.IO;

public class Zadanie7
{
    public static void Run()
    {
        string sourcePath = @"C:\sciezka\duzyplik.bin";
        string destPath = @"C:\sciezka\duzyplik_kopia.bin";

        // Tworzenie dużego pliku, jeśli nie istnieje
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Tworzenie dużego pliku (300MB)...");
            using (FileStream fs = new FileStream(sourcePath, FileMode.CreateNew))
            {
                fs.SetLength(300 * 1024 * 1024);
            }
            Console.WriteLine("Duży plik został utworzony.");
        }

        // Kopiowanie z pomiarem czasu
        Stopwatch sw = new Stopwatch();
        sw.Start();

        using (FileStream source = new FileStream(sourcePath, FileMode.Open))
        using (FileStream dest = new FileStream(destPath, FileMode.Create))
        {
            source.CopyTo(dest);
        }

        sw.Stop();

        Console.WriteLine($"Czas kopiowania dużego pliku: {sw.Elapsed.TotalSeconds:F2} sekund");
    }
}

