string szoveg = "", forditott = "";
int i = 0;
Console.WriteLine("Szöveg: ");
szoveg = Console.ReadLine();
for (i = szoveg.Length - 1; i >= 0; i--)
    forditott = forditott + szoveg[i];
Console.WriteLine("Visszafelé:");
Console.WriteLine(forditott.ToLower());
