// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kérek egy szöveget: ");
string szoveg = Console.ReadLine();
int i = 0;
while (i < szoveg.Length)
{
    Console.WriteLine(szoveg[i]);
    i++;


}

Console.WriteLine( );
i = szoveg.Length - 1;
while (i >= 0)
{
    Console.WriteLine(szoveg[i]);
    i--;

}
