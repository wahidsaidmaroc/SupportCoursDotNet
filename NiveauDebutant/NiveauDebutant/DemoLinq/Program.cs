
using DemoLinq;
var etudiantService = new EtudiantService();
var etudiants = etudiantService.getList();


var groupeService = new GroupeService();
var groupes = groupeService.getList();

//#region "Old Method"
//var listeEtudiantSup10 = new List<Etudiant>();
//foreach (var item in source)
//{
//    if (item.note >= 10)
//    {
//        listeEtudiantSup10.Add(item);
//    }
//}
//#endregion

//#region "pour afficher les listes"
////Using foreach Linq Method
//listeEtudiantSup10.ForEach(item => Console.WriteLine(item.nom));
//#endregion



//// Linq Par syntaxe de requête
//var ListLinq = (from item in source
//                              where item.note >= 10
//                              select item).ToList();


////Linq par Methode
//var ListLinqMethode = source.Where(item => item.note >= 10)


//    .ToList();

//Take : 
var take = etudiants.OrderByDescending(a => a.note ).Take(5).ToList();

//Skip
var skipe = etudiants.Skip(5).ToList();

foreach (var item in take)
{
    Console.WriteLine(item.nom);
}

//TakeWhile
var takeWhile = etudiants.TakeWhile(a => a.note > 10).ToList();

//Concat
var liste1 = new int[] { 1, 2, 3, 4, 5 };
var liste2 = new int[] { 6, 7, 8, 9, 10 };
var numbers = liste1.Concat(liste2).ToList();




//Linq Query
var noms = from e in etudiants
           where e.note >= 10 
           orderby e.note descending
           select e.nom;


Console.WriteLine("Liste des étudiants ayant une note supérieure ou égale à 10");
foreach (var item in noms)
{
    Console.WriteLine(item);
}


//by methode
Console.WriteLine("Liste des étudiants ayant une note supérieure à 10");
var linqMethode = etudiants.Where(a => a.note > 10)
                    .Select(a => a.nom).ToList();
linqMethode.ForEach(item => Console.WriteLine(item));





//Linq syntax Query 
var l1 = from l in etudiants
         where l.note > 2 && l.note < 6 
         select new { l.nom, message = "Tres faible", l.note };
Console.WriteLine("Liste des étudiants ayant une note entre 2 et 6");
foreach (var item in l1)
{
    Console.WriteLine(item.nom + " - Messsage Prof. " + item.message + " Note :  " + item.note);
}


//Linq syntax Query 
var l2 = from l in etudiants
         where l.note > 12
         where l.note < 14
         orderby l.note descending
         select l;

var lM = etudiants.Where(a => a.note > 12).Where(l => l.note < 14);


foreach (var item in l1)
{
    Console.WriteLine(item.nom);
}


var element = etudiants.Where(e => e.id == 120).FirstOrDefault ();


if (element == null)
{
    Console.WriteLine("Element non trouvé");
}
else
{
    Console.WriteLine(element.id);
    Console.WriteLine(element.nom);
    Console.WriteLine(element.note);
}






//Linq syntax Query 
var result = from l in etudiants
    where IsIntervalle(l)
    select l;

foreach (var item in l1)
{
Console.WriteLine(item.nom);
}



var list = from g in groupes
           join e in etudiants

            on g.id equals e._idGroup

           select new { nomEtudiant = e.nom, gr = g.nom , note = e.note };

foreach (var item in list)
{
    Console.WriteLine("Nom : {1}        - Group {0}     - Note :{2}", item.gr, item.nomEtudiant, item.note);
}



Console.ReadKey();







static bool IsIntervalle(Etudiant a)
{
    //other Conditions
    return a.note > 12 && a.note < 14;
}




