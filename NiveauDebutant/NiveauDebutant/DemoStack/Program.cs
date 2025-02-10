var stackName = new Stack<string>();
stackName.Push("1 Kaoutar");
stackName.Push("2 khalid");
stackName.Push("3 Ayoub");
stackName.Push("4 Adam");
stackName.Push("5 Zouhair");
stackName.Push("6 Salim");
stackName.Push("7 Kenza");
stackName.Push("8 Ismail");


string last = stackName.Pop();
Console.WriteLine(last);

string last2 = stackName.Pop();
Console.WriteLine(last2);


stackName.Push("9 Amine");
string last3 = stackName.Pop();
Console.WriteLine(last3);


stackName.Contains("said");

string lastNoDelete =  stackName.Peek();



foreach (var item in stackName)
{
    Console.WriteLine(item);
    //Remove
   
}


foreach (var item in stackName)
{
    Console.WriteLine(item);
}