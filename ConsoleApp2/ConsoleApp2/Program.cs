Console.Write("Másodfokú tag együtthatója: ");
float a = float.Parse(Console.ReadLine());
Console.Write("Elsőfokú tag együtthatója: ");
float b = float.Parse(Console.ReadLine());
Console.Write("Nulladfokú tag együtthatója: ");
float c = float.Parse(Console.ReadLine());
float d = b * b - 4 * a * c;
double dd =Math.Pow(b, 2)  -4 * a * c;
if (d < 0)
    Console.WriteLine("Nincs valós megoldás");
else if (d > -0.000001 && d < 0.000001)
    Console.WriteLine("{0:0.00} kétszeres gyök.",-b / (2*a));
else Console.WriteLine("{0:0.00 és {1:0.00} a gyökök",
        (-b + Math.Pow(dd, .5)) / (2 * a),
        (-b - Math.Pow(dd, .5)) / (2 * a));


