var q = new Queue<string>();
q.Enqueue("Je suis le 1");
q.Enqueue("Je suis le 2eme");
q.Enqueue("Je Suis le 3 eme");


Console.WriteLine("Tapez votre classement :");
// Pour ajouter un élément à la queue
q.Enqueue(Console.ReadLine());

foreach (var item in q)
{
    Console.WriteLine(item);
}


var FirstElement = q.Dequeue();
var SecondesElement = q.Dequeue();


