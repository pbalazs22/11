
Console.WriteLine("Adj meg egy számot:");
int val = int.Parse(Console.ReadLine());
int i, j;
// i sor j a csillag
for (i = 1; i <= val; i++)
{
    for (j = 0; j <= val - i; j++) // csillagok szama nő
        Console.Write("*");
    Console.WriteLine("");
}




