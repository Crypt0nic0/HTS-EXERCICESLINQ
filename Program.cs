using EXERCICESLINQ;

Console.WriteLine("===========IENUMERABLE===========");


var liste = new MaListe(10);
foreach (var item in liste)
{
    Console.WriteLine(item);
}


Console.WriteLine("===========METHODE EXTENSION===========");

int[] tab = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(tab.CompterPair());