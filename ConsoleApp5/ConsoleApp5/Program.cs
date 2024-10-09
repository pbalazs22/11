int[] egeszek = new int[30];
Random rnd = new Random();
for (int i = 0; i < egeszek.Length; i++)
    egeszek[i] = rnd.Next(0, 100);

foreach (int item in egeszek)

    Console.WriteLine("{0}", item);

Console.WriteLine();
Console.WriteLine("1. elem: {0}", egeszek[0]);
Console.WriteLine("15.elem: {0}", egeszek[14]);
Console.WriteLine("utolso elem: {0}" egeszek[egeszek.Length - 1]);