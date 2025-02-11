//Dans cet exemple :

//Publisher déclare un événement SomethingHappened.
//Subscriber s'abonne à cet événement et définit une méthode HandleEvent pour gérer l'événement.
//Lorsque Publisher appelle DoSomething, l'événement est déclenché et Subscriber est notifié.
using System;
class Program
{
    static void Main()
    {
        //Exemple 1 : 
        // créer un timer avec 3seconde
        System.Timers.Timer timer = new System.Timers.Timer();
        timer.Interval = 3000; // 3 seconds
        timer.Elapsed += Timer_Elapsed;


        timer.Start();

        Console.ReadLine();
        timer.Elapsed -= Timer_Elapsed;


        //Exemple 2 
        //Publisher publisher = new Publisher();
        //Subscriber subscriber = new Subscriber();

        //subscriber.Subscribe(publisher);
        //publisher.DoSomething();
    }

    private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("Salam");
    }




}

public class Publisher
{
    // Déclaration de l'événement
    public event EventHandler SomethingHappened;

    public void DoSomething()
    {
        // Déclenchement de l'événement
        OnSomethingHappened(EventArgs.Empty);
    }

    protected virtual void OnSomethingHappened(EventArgs e)
    {
        SomethingHappened?.Invoke(this, e);
    }
}


public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.SomethingHappened += HandleEvent;
    }

    private void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("L'événement a été déclenché !");
    }
}