Random veletlen = new Random();
int veletlenSzam;
for ( int i = 1; i < 7; i++ )
    {
    veletlenSzam = veletlen.Next(61);
    Console.Write( "{0}",veletlenSzam );
    }
Console.WriteLine();
