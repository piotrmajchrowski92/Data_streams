using System;
using System.IO;

public class Zadanie5
{
    public static void Run()
    {
        string path = @"C:\sciezka\dane.bin";

        Console.WriteLine("Wybierz operację:\n1 - Zapis danych\n2 - Odczyt danych");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                using (FileStream fs = new FileStream(path, FileMode.Create))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    Console.Write("Podaj imię: ");
                    writer.Write(Console.ReadLine());

                    Console.Write("Podaj wiek: ");
                    writer.Write(int.Parse(Console.ReadLine()));

                    Console.Write("Podaj adres: ");
                    writer.Write(Console.ReadLine());

                    Console.WriteLine("Dane zapisane pomyślnie.");
                }
                break;

            case "2":
                if (!File.Exists(path))
                {
                    Console.WriteLine("Plik nie istnieje.");
                    return;
                }

                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    string imie = reader.ReadString();
                    int wiek = reader.ReadInt32();
                    string adres = reader.ReadString();

                    Console.WriteLine($"\nImię: {imie}\nWiek: {wiek}\nAdres: {adres}");
                }
                break;

            default:
                Console.WriteLine("Nieznana opcja.");
                break;
        }
    }
}

