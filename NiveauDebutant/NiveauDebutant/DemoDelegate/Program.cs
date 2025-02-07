using System;

namespace DemoDelegate
{
    // Déclaration d'un délégué
    public delegate void DisplayMessage(string message);

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation du délégué avec une méthode
            DisplayMessage messageDelegate = ShowMessage;

            // Appel du délégué
            messageDelegate("Bonjour, étudiants!");

            // Utilisation du délégué avec une méthode anonyme
            messageDelegate = delegate (string msg)
            {
                Console.WriteLine($"Message anonyme: {msg}");
            };
            messageDelegate("Ceci est un message anonyme.");

            // Utilisation du délégué avec une expression lambda
            messageDelegate = (msg) => Console.WriteLine($"Message lambda: {msg}");
            messageDelegate("Ceci est un message lambda.");
        }

        // Méthode qui correspond à la signature du délégué
        static void ShowMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
}
