Console.Write("Pontszámod? ");
int psz = int.Parse(Console.ReadLine());
if (psz >= 150 * .8)
    Console.WriteLine("Jeles(5)");
else if (psz >= 150 * .6)
    Console.WriteLine("Jó(4)");
else if (psz >= 150 * .4)
    Console.WriteLine("Közepes(3)");
else if (psz >= 150 * .25)
    Console.WriteLine("Elégséges(2)");
else Console.WriteLine("Elégtelen(1)");