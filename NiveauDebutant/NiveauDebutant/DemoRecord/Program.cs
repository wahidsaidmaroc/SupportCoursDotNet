//Exemple 1 : Record Simple
public record Person(string FirstName, string LastName);



//Exemple 2 : Record avec Méthode
public record PersonWithMethod(string FirstName, string LastName)
{
    public string FullName => $"{FirstName} {LastName}";

    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}



//Exemple 3 : Record avec Héritage

public record Employee(string FirstName, string LastName, string Position) : Person(FirstName, LastName);


//Exemple 4 : Record avec Propriétés Immuables
public record Car
{
    public string Make { get; init; }
    public string Model { get; init; }
    public int Year { get; init; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}


//Exemple 5 : Record Struct
public readonly record struct Point(int X, int Y);