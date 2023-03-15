
string[] favouritePlates = { "Pizza", "Pasta al sugo", "Caprese", "Pasta in bianco", "Tiramisù" };

Console.WriteLine(favouritePlates.Length);

for (int i = 0; i < favouritePlates.Length; i++)
{
    Console.WriteLine(favouritePlates[i]);
}

Console.WriteLine("Classifica dei piatti preferiti: ");
Console.WriteLine("1-" + favouritePlates[0]);
Console.WriteLine("2-" + favouritePlates[1]);
Console.WriteLine("3-" + favouritePlates[2]);
Console.WriteLine("4-" + favouritePlates[3]);
Console.WriteLine("5-" + favouritePlates[4]);

Console.WriteLine("Piatto preferito: " + favouritePlates[0]);
Console.WriteLine("Piatto preferito ma non troppo: " + favouritePlates[4]);

Console.WriteLine("A metà classifica c'è: " + favouritePlates[3]);