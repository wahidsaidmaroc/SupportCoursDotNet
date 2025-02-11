namespace DemoLinq;


/// <summary>
/// Service pour les étudiants
/// </summary>
public class EtudiantService
{

    public List<Etudiant> getList()
    {
        var list = new List<Etudiant>()
            {
                new Etudiant() { id = 1, nom = "Haroun", prenom = "ALAOUI" ,note = 18 , ville = "Meknes", _idGroup = 1},
                new Etudiant() { id = 2, nom = "Abdelahe", prenom = "ALAOUI" ,note = 20, ville ="Casa" , _idGroup = 2},
                new Etudiant() { id = 3, nom = "Kaoutar", prenom = "ALAOUI", note = 17 , ville =  "Rabat", _idGroup = 3},
                new Etudiant() { id = 4, nom = "Hamza",prenom = "ALAOUI" , note = 14 , ville = "Mohmadia", _idGroup = 2},
                new Etudiant() { id = 5, nom = "Said", prenom = "ALAOUI", note = 10 , ville = "Berrchid", _idGroup = 3 },
                new Etudiant() { id = 6, nom = "Amine",prenom = "ALAOUI" , note = 17 , ville = "Rabat", _idGroup = 1},
                new Etudiant() { id = 7, nom = "Ahmed",prenom = "ALAOUI" , note = 9 , ville = "Casa", _idGroup = 4},
                new Etudiant() { id = 8, nom = "Mohamed",prenom = "ALAOUI" , note = 20, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 9, nom = "Youssef",prenom = "ALAOUI" , note = 20, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 10, nom = "Hasnaoui",prenom = "ALAOUI" , note = 19, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 11, nom = "Abdelatif",prenom = "ALAOUI" , note = 14, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 12, nom = "Abdelghni",prenom = "ALAOUI" , note = 10, ville ="Casablanca" , _idGroup = 2},
                new Etudiant() { id = 13, nom = "Ihssan",prenom = "ALAOUI" , note = 13, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 14, nom = "Nada",prenom = "ALAOUI" , note = 17, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 15, nom = "Khadija",prenom = "ALAOUI" , note = 17, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 16, nom = "Ayoub", prenom = "ALAOUI" ,note = 17, ville ="Casablanca" , _idGroup = 3},
                new Etudiant() { id = 17, nom = "Rachid",prenom = "ALAOUI" , note = 18, ville ="Rabat" , _idGroup = 4},
                new Etudiant() { id = 18, nom = "Adam", prenom = "ALAOUI" ,note = 13, ville ="Berrchid" , _idGroup = 4},
                new Etudiant() { id = 19, nom = "Zouhair", prenom = "ALAOUI" ,note = 10, ville ="Tanger" , _idGroup = 4},
                new Etudiant() { id = 20, nom = "Mustapha", prenom = "ALAOUI" ,note = 9, ville ="Fes" , _idGroup = 3},
                new Etudiant() { id = 21, nom = "Kenza", prenom = "ALAOUI" ,note = 18, ville ="Rabat" , _idGroup = 3},
                new Etudiant() { id = 22, nom = "Ismail", prenom = "ALAOUI" ,note = 17, ville ="Kenitra" , _idGroup = 3},
                new Etudiant() { id = 23, nom = "Amine", prenom = "ALAOUI" ,note = 16, ville ="Sale" , _idGroup = 3},
                new Etudiant() { id = 24, nom = "Yassine", prenom = "ALAOUI" ,note = 3, ville ="Rabat" , _idGroup = 3},

            };
        return list;
    }

}
