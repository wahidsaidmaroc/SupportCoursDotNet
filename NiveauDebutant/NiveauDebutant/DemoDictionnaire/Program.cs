using DemoDictionnaire;

var ListeVille = new Dictionary<int, string>();
ListeVille.Add(20, "Casablanca"); // Index 0
ListeVille.Add(2, "Rabat");     // Index 1
ListeVille.Add(3, "Tanger");     // Index 2
ListeVille.Add(4, "Fès");
ListeVille.Add(5, "Marrakech");
ListeVille.Add(6, "Agadir");
ListeVille.Add(7, "Oujda");
ListeVille.Add(8, "Tétouan");
ListeVille.Add(9, "Kénitra");
ListeVille.Add(11, "Dakhla");


foreach (var item in ListeVille)
{
    Console.WriteLine($"Clé: {item.Key}, Valeur: {item.Value}");
}


var listeVille = new Dictionary<string, string>();

listeVille.Add("MA", "Casa, Fes, Rabat");
listeVille.Add("ma", "Casa, Fes, Rabat");
listeVille.Add("FR", "Paris , nante");


IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "Un"); //adding a key/value using the Add() method
numberNames.Add(2, "Deux");
numberNames.Add(3, "Cinq");


var listClient = new Dictionary<int, Client>();
listClient.Add(20, new Client { Id = 1, Nom = "Ahmed" });
listClient.Add(10, new Client { Id = 2, Nom = "Mohamed" });
listClient.Add(30, new Client {    Id =3 ,
    Nom = "Ali"
});

