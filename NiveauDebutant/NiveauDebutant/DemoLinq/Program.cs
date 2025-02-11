
using DemoLinq;
var etudiantService = new EtudiantService();
var source = etudiantService.getList();

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



//Linq Query
var noms = from e in source
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
var linqMethode = source.Where(a => a.note > 10)
                    .Select(a => a.nom).ToList();
linqMethode.ForEach(item => Console.WriteLine(item));





//Linq syntax Query 
var l1 = from l in source
         where l.note > 2 && l.note < 6 
         select new { l.nom, message = "Tres faible", l.note };
Console.WriteLine("Liste des étudiants ayant une note entre 2 et 6");
foreach (var item in l1)
{
    Console.WriteLine(item.nom + " - Messsage Prof. " + item.message + " Note :  " + item.note);
}


//Linq syntax Query 
var l2 = from l in source
         where l.note > 12
         where l.note < 14
         orderby l.note descending
         select l;

var lM = source.Where(a => a.note > 12).Where(l => l.note < 14);


foreach (var item in l1)
{
    Console.WriteLine(item.nom);
}


var element = source.Where(e => e.id == 120).FirstOrDefault ();


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
var result = from l in source
    where IsIntervalle(l)
    select l;

foreach (var item in l1)
{
Console.WriteLine(item.nom);
}





Console.ReadKey();







static bool IsIntervalle(Etudiant a)
{
    //other Conditions
    return a.note > 12 && a.note < 14;
}