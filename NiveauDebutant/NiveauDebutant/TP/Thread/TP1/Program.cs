using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Task1();
        //Task2();

        //// Créer un thread pour exécuter la méthode DoWork
        Thread thread1 = new Thread(new ThreadStart(Task1));
        Thread thread2 = new Thread(new ThreadStart(Task2));


        Thread.Sleep(5000);

        thread1.Start();
        thread2.Start();

        // Exécuter une autre tâche dans le thread principal
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Tâche principale : " + i);
            Thread.Sleep(1000); // Pause de 1 seconde
        }

        // Attendre que le thread secondaire se termine
        thread1.Join();
        Console.WriteLine("Le thread secondaire est terminé.");
    }

    static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread secondaire : " + i);
            Thread.Sleep(1000); // Pause de 1 seconde
        }
    }


    static void Task1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Task 1 : " + i);
            Thread.Sleep(1000); // Pause de 1 seconde
        }
    }

    static void Task2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Task 2 : " + i);
            Thread.Sleep(1000); // Pause de 1 seconde
        }
    }


}