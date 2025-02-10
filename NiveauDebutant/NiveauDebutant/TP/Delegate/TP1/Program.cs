class Program
{
    
// Déclaration du délégué
public delegate int MathOperation(int a, int b);


    #region "Operation"


    // Méthodes pour les opérations mathématiques
    public static int Add(int a, int b)
{
    return a + b;
}

public static int Subtract(int a, int b)
{
    return a - b;
}

public static int Multiply(int a, int b)
{
    return a * b;
}

public static int Divide(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Erreur : Division par zéro !");
        return 0;
    }
    return a / b;
}

    #endregion

    // Méthode pour exécuter l'opération
//public static void ExecuteOperation(MathOperation operation, int a, int b)
//{
//    int result = operation(a, b);
//    Console.WriteLine("Le résultat est : " + result);
//}

public static void Main()
{
    Console.WriteLine("Choisissez une opération :");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Soustraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    int choice = int.Parse(Console.ReadLine());

    Console.WriteLine("Entrez le premier nombre :");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Entrez le deuxième nombre :");
    int num2 = int.Parse(Console.ReadLine());

    MathOperation operation = null;

    switch (choice)
    {
        case 1:
            operation = Add;
            break;
        case 2:
            operation = Subtract;
            break;
        case 3:
            operation = Multiply;
            break;
        case 4:
            operation = Divide;
            break;
        default:
            Console.WriteLine("Choix invalide !");
            return;
    }

        int result = operation(num1, num2);
        Console.WriteLine("Le résultat est : " + result);

        //ExecuteOperation(operation, num1, num2);
}

}