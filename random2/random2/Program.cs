Random veletlen = new Random();
int a = veletlen.Next(6) + 1;
int b = veletlen.Next(6) + 1;
if (a > b)
    Console.WriteLine("{0} > {1}", a, b);
else if (b > a) 
    Console.WriteLine("{0} < {1}", a, b);
else
    Console.WriteLine("{0} = {1}", a, b);
