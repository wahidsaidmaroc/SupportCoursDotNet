


using DemoGenerique;

var ajouterCl = new Ajouter<Client>();
var client = new Client();
ajouterCl.AjouterMethod(client);


Fournisseur fournisseur = new Fournisseur();
var ajouterFourn = new Ajouter<Fournisseur>();
ajouterFourn.AjouterMethod(fournisseur);
