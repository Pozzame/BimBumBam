/*start: Console.WriteLine("Pari o dispari? (p/d)");
string pod = Console.ReadLine()!.ToLower();*/
string pod = "a";
while (pod != "p" && pod != "d")
{
    Console.WriteLine("Pari o dispari? (p/d)");
    pod = Console.ReadLine()!.ToLower();
}
/*if (pod != "p" && pod != "d")
{
    Console.WriteLine("Scelta non valida");
    goto start;
}*/
int num = 6;
while (num < 0 || num > 5)
{
    Console.WriteLine("Scegli un numero tra 0 e 5.");
    num = Convert.ToInt32(Console.ReadLine());
}
/*num: Console.WriteLine("Scegli un numero tra 0 e 5.");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0 || num > 5)
{
    Console.WriteLine("Scelta non valida");
    goto num;
}*/

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