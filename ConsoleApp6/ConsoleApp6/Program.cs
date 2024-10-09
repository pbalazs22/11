int elemszam = 100;
int fej = 0;
int iras  = 0;
int[] veletlenszamok = new int[elemszam];
Random elem = new Random();
for (int i = 0; i < veletlenszamok.Length; i++);

    veletlenszamok[i] = elem.Next(0, 2);

foreach (int tombelem in veletlenszamok)

    if (tombelem == 0)
        Console.WriteLine("fej", tombelem);
    else
        Console.WriteLine("írás", tombelem);

Console.WriteLine("fej: {0}", fej);
Console.WriteLine("írás: {0}", iras);
