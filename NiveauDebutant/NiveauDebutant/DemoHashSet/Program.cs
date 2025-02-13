﻿HashSet<string> myhash1 = new HashSet<string>();

// Add the elements in HashSet
// Using Add method
myhash1.Add("C");
myhash1.Add("C++");
myhash1.Add("C++");
myhash1.Add("C#");
myhash1.Add("Java");
myhash1.Add("C++");
myhash1.Add("Ruby");
myhash1.Add("Ruby");

Console.WriteLine("Elements of myhash1:");

// Accessing elements of HashSet
// Using foreach loop
foreach (var val in myhash1)
{
    Console.WriteLine(val);
}

// Creating another HashSet
// using collection initializer
// to initialize HashSet
HashSet<int> myhash2 = new HashSet<int>()
{10,   100,1000,10000,100000};

// Display elements of myhash2
Console.WriteLine("Elements of myhash2:");
foreach (var value in myhash2)
{
    Console.WriteLine(value);
}




#region "Union"
// Creating HashSet
// Using HashSet class
var myhashD1 = new HashSet<string>();

// Add the elements in HashSet
// Using Add method
myhashD1.Add("C");
myhashD1.Add("C++");
myhashD1.Add("C#");
myhashD1.Add("Java");
myhashD1.Add("Ruby");

// Creating another HashSet
// Using HashSet class
var myhashD2 = new HashSet<string>();

// Add the elements in HashSet
// Using Add method
myhashD2.Add("PHP");
myhashD2.Add("C++");
myhashD2.Add("Perl");
myhashD2.Add("Java");

// Using UnionWith method
myhashD1.UnionWith(myhashD2);


foreach (var ele in myhashD1)
{
    Console.WriteLine(ele);
}
#endregion




#region "IntersectWith"
//This method combines the elements that are common
//to both the collections.
var names = new HashSet<string> {
                "Said",
                "Salim",
                "Sara"
            };
var names1 = new HashSet<string> {
                "Amine",
                "Mehdi",
                "Khalid",
                "Said",
                "Kenza"
            };
names.IntersectWith(names1);

foreach (var name in names)
{
    Console.WriteLine(name);
}
#endregion


#region "ExceptWith"

//This method removes all the elements that are present in the other collections from the collection on which it is called.
HashSet<string> namesExceptWith = new HashSet<string> {
                "Khalid",
                "Mohamed",
                "Fahd"
            };


HashSet<string> names1ExceptWith = new HashSet<string> {
                "Kenza",
                "Khalid",
                "omar",
                "ismail",
                "salim"
            };
names1ExceptWith.ExceptWith(namesExceptWith);
foreach (var name in names1ExceptWith)
{
    Console.WriteLine(name);
}
#endregion

Console.ReadKey();  