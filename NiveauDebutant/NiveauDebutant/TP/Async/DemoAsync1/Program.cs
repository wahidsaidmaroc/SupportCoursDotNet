using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Début du programme");

        // Appel de la méthode asynchrone
        DoWorkAsyncOne();
        await DoWorkAsyncSec();

        Console.WriteLine("Fin du programme");
    }

    static async Task DoWorkAsyncOne()
    {
        Console.WriteLine("Début de DoWorkAsync 1");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Task 1 : " + i);
            // Simuler une opération asynchrone avec Task.Delay
            await Task.Delay(2000); // Pause de 2 secondes
        }
       

        Console.WriteLine("Fin de DoWorkAsync 1");
    }

    static async Task DoWorkAsyncSec()
    {
        Console.WriteLine("Début de DoWorkAsync 2");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Task 2 : " + i);
            // Simuler une opération asynchrone avec Task.Delay
            await Task.Delay(2000); // Pause de 2 secondes
        }

        Console.WriteLine("Fin de DoWorkAsync 2");
    }

}