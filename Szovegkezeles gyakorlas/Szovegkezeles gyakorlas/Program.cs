Console.WriteLine("Kérek egy szót: ");
string szo = Console.ReadLine();
Console.WriteLine("Hossza: {0}",szo.Length);

Console.WriteLine("Kérek egy szót: ");
string szo2 = Console.ReadLine();
Console.WriteLine("{0} + {1} = {2}", szo, szo2, szo + szo2);
Console.WriteLine("{0} + {1} = {2}", szo2, szo, szo2 + szo);

Console.Write("Kérek egy 3. szót: ");
string szo3 = Console.ReadLine();
for (int i = 0; i < szo3.Length; i++)
    Console.Write("{0} ", szo3[i]);
Console.WriteLine();

Console.WriteLine("Kérek egy szót: ");
string szo41 = Console.ReadLine();
Console.WriteLine("Kérek még egy szót: ");
string szo42 = Console.ReadLine();
if (szo41.CompareTo(szo42) < 0)
    Console.WriteLine("Első a {0} szó.", szo41);
else
    Console.WriteLine("Első a {0} szó.", szo42);

