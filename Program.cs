string pod = "a";
while (pod != "p" && pod != "d")
{
    Console.WriteLine("Pari o dispari? (p/d)");
    pod = Console.ReadLine()!.ToLower();
}

int num = 6;
while (num < 0 || num > 5)
{
    Console.WriteLine("Scegli un numero tra 0 e 5.");
    num = Convert.ToInt32(Console.ReadLine());
}

Random rng = new Random();
int segreto = rng.Next(0,5);
if ((segreto + num) %2 == 0 )
{
    if (pod == "p")
    {
        Console.WriteLine($"Hai vinto! :-D, il numero scelto era {segreto}");
    }
    else
    {
        Console.WriteLine($"Hai perso! :-(, il numero scelto era {segreto}");
    }
}
else if ((segreto + num) %2 != 0)
{
    if (pod == "d")
    {
        Console.WriteLine($"Hai vinto! :-D, il numero scelto era {segreto}");
    }
    else
    {
        Console.WriteLine($"Hai perso! :-(, il numero scelto era {segreto}");
    }
}