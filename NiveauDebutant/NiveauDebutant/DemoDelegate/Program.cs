



public class Program
{

    public delegate List<SalarieReturn> GetListSalarieDeleget(decimal Salaire, List<Personne> list);


    public static void Main()
    {
        List<Personne> listPersonnel = new List<Personne>()
        {
            new Personne() { id = 1, Nom = "Personne 1", Salaire = 1000 },
            new Personne() { id = 2, Nom = "Personne 2", Salaire = 2000 },
            new Personne() { id = 3, Nom = "Personne 3", Salaire = 3000 },
            new Personne() { id = 4, Nom = "Personne 4", Salaire = 4000 },
            new Personne() { id = 5, Nom = "Personne 5", Salaire = 5000 },
            new Personne() { id = 6, Nom = "Personne 6", Salaire = 6000 },
            new Personne() { id = 7, Nom = "Personne 7", Salaire = 7000 },
            new Personne() { id = 8, Nom = "Personne 8", Salaire = 8000 },
            new Personne() { id = 9, Nom = "Personne 9", Salaire = 9000 },
            new Personne() { id = 10, Nom = "Personne 10", Salaire = 10000 }
        };

        var getListSalarieDeleget = new GetListSalarieDeleget(GetListePersonnel);

        
        var result = getListSalarieDeleget(5000, listPersonnel);


        foreach (var item in result)
        {
            Console.WriteLine("Id : " + item.Id + " Nom : " + item.Nom);
        }
    }
    public static List<SalarieReturn> GetListePersonnel(decimal SalaireSource, List<Personne> listPersonnel)
    {
        var returnData = new List<SalarieReturn>();
        //Condition 
        foreach (var item in listPersonnel)
        {
            if (item.Salaire > SalaireSource)
            {
                var obj = new SalarieReturn()
                { Id = item.id, Nom = item.Nom };
                returnData.Add(obj);
            }
        }
        return returnData;
    }
}














public class Personne
{
    public int id { get; set; }
    public string Nom { get; set; }
    public decimal Salaire { get; set; }
}


public class SalarieReturn
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;

}