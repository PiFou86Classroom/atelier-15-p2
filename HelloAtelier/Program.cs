Console.Out.WriteLine("Entrez votre prénom suivi de enter");
var prenom = Console.In.ReadLine();

Console.Out.WriteLine("Entrez votre nom suivi de enter");
var nom = Console.In.ReadLine();

var sortie = "Hello ";
sortie += prenom;
sortie += " ";
sortie += nom.ToUpper();

Console.Out.WriteLine(sortie);
