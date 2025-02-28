// See https://aka.ms/new-console-template for more information
using DemoClassPartial;

Console.WriteLine("Hello, World!");


Produit produit = new Produit();    
produit.Add();
produit.Id = 1;




//Avantages des Classes Partielles
//Organisation du Code :
//  Permet de séparer les différentes parties d'une classe en plusieurs fichiers,
//  ce qui rend le code plus lisible et plus facile à maintenir.
//Collaboration : Facilite le travail en équipe en permettant à plusieurs développeurs de travailler sur différentes parties de la même classe sans entrer en conflit.
//Génération de Code : Utile pour les outils de génération de code qui peuvent ajouter du code à une classe sans écraser le code existant.