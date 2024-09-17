Console.WriteLine("Kérem a víz hőmérsékletét Celsius fokban: ");
float h = float.Parse(Console.ReadLine());
if (h < 0)
    Console.WriteLine("Szilárd");
else if (h > 100)
    Console.WriteLine("Légnemű");
else Console.WriteLine("Folyékony");
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++; // i= i +1 vagy i+=1

}

