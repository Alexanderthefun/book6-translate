using System;
//cntrl + shift + P 
// .net generate assets for build and debug
//select the appropriate file.

Main();

void Main()
{
Dictionary<string, List<object>> tables = new Dictionary<string, List<object>>();
tables.Add("Table 1", new List<object>());
tables.Add("Table 2", new List<object>());

foreach (obj guest in guests)
{
var table1Occupations = tables["Table 1"].Select(g => g.occupation).ToList();
if (table1Occupations.Contains(guest.occupation))
{
    tables["Table 2"].Add(guest);
}
else
{
    tables["Table 1"].Add(guest);
}
}

foreach (var tableName in tables.keys)
{
    var tableGuests = tables[tableName];
    Console.WriteLine(tableName);
    foreach (var guest in tableGuests)
    {
        Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
    }
}

public class Person
{
    public string name { get; set; }
    public string occupation { get; set; }
    public string bio { get; set; }
}

Person[] guests = new Person[8];

guests[0] = new Person { name = "Marilyn Monroe", occupation = "entertainer", bio = "(1926 - 1962) American actress, singer, model"};
guests[1] = new Person { name = "Abraham Lincoln", occupation = "politician", bio = "(1809 - 1865) US President during American civil war"};
guests[2] = new Person { name = "Martin Luther King", occupation = "activist", bio = "(1929 - 1968)  American civil rights campaigner"};
guests[3] = new Person { name = "Rosa Parks", occupation = "activist", bio = "(1913 - 2005)  American civil rights activist"};
guests[4] = new Person { name = "Peter Sellers", occupation = "entertainer", bio = "(1925 - 1980) British actor and comedian"};
guests[5] = new Person { name = "Alan Turing", occupation = "computer scientist", bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"};
guests[6] = new Person { name = "Admiral Grace Hopper", occupation = "computer scientist", bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"};
guests[6] = new Person { name = "Indira Gandhi", occupation = "politician", bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"};

}