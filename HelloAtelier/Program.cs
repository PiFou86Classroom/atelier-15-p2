Console.Out.WriteLine("Entrez votre prénom suivi de enter");
string? prenom = Console.In.ReadLine();

Console.Out.WriteLine("Entrez votre nom suivi de enter");
string? nom = Console.In.ReadLine();

string sortie = "Hello ";
sortie += prenom;
sortie += " ";
sortie += nom.ToUpper();

Console.WriteLine(sortie);
