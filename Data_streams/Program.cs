
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz zadanie (3-7):");
        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "3":
                Zadanie3.Run();
                break;
            case "4":
                Zadanie4.Run();
                break;
            case "5":
                Zadanie5.Run();
                break;
            case "6":
                Zadanie6.Run();
                break;
            case "7":
                Zadanie7.Run();
                break;
            default:
                Console.WriteLine("Niepoprawny wybór zadania.");
                break;
        }

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}

