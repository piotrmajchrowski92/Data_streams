using System;
using System.IO;
using System.Linq;

public class Zadanie4
{
    public static void Run()
    {
        string path = @"C:\sciezka\plik.txt";

        if (!File.Exists(path))
        {
            Console.WriteLine("Plik nie istnieje.");
            return;
        }

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            Console.WriteLine("Odwrócona zawartość pliku:\n");
            while ((line = reader.ReadLine()) != null)
            {
                char[] reversedLine = line.Reverse().ToArray();
                Console.WriteLine(new string(reversedLine));
            }
        }
    }
}

