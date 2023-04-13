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




Console.WriteLine("===========EXERCICES FINAUX===========");

List<Personne> personnes = new()
{
    new() { Nom = "Dupont", Prenom = "Jean", TailleCm = 175, Sexe = Sexe.Homme },
    new() { Nom = "Dupont", Prenom = "Jeanne", TailleCm = 156, Sexe = Sexe.Femme, DateNaissance = new(1956,10,5)},
    new() { Nom = "Durand", Prenom = "Marc", TailleCm = 192, Sexe = Sexe.Homme, DateNaissance = new(1959,10,5)},
    new() { Nom = "Thomas", Prenom = "Gérard", TailleCm = 182, Sexe = Sexe.Homme },
    new() { Nom = "Greneche", Prenom = "Nicolas", TailleCm = 183, Sexe = Sexe.Homme, DateNaissance = new(1990,07,18)},
    new() { Nom = "Faucheux", Prenom = "Marine", TailleCm = 171, Sexe = Sexe.Femme, DateNaissance = new(1990,09,11)}
};


Console.WriteLine("Liste des noms de famille : ");
List<string> nomsDeFamille = personnes.Select(p => p.Nom).ToList();
foreach (var item in nomsDeFamille)
{
    Console.WriteLine(item);
}

Console.WriteLine("Liste des personnes qui ont une date de naissance");
List<Personne> pdn = personnes.Where(p => p.DateNaissance.HasValue).ToList();
foreach (var item in pdn)
{
    Console.WriteLine(item.Nom);
}

Console.WriteLine("Est-ce qu'il y a au moins une femme dans la liste des personnes ?");
string m = (personnes.Any(p => p.Sexe == Sexe.Femme)) ? "Yes !" : "No !";
Console.WriteLine(m);

Console.WriteLine("Est-ce que tous les prénoms font au moins 3 lettres ?");
m = (personnes.All(p => p.Prenom.Length >= 3)) ? "Yes !" : "No !";
Console.WriteLine(m);

Console.WriteLine("Affichage des personnes triées par Nom puis Prénom");
List<Personne> l = personnes.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList();
foreach (var item in l)
{
    Console.WriteLine($"{item.Nom} {item.Prenom}");
}
