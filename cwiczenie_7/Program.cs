Console.Write($"Podaj x punktu: ");
double x = double.Parse(Console.ReadLine());
Console.Write($"Podaj y punktu: ");
double y = double.Parse(Console.ReadLine());
Console.Write($"Podaj r: ");
double r = double.Parse(Console.ReadLine());

// środek koła
double a = 0;
double b = 0;

//obliczenia
double pierwszyNawias = x - a;
double drugiNawias = y - b;
double lewaStrona = Math.Pow(pierwszyNawias, 2) + Math.Pow(drugiNawias, 2);
double prawaStrona = Math.Pow(r, 2);

//sprawdzenie
if (lewaStrona <= prawaStrona)
{
    Console.WriteLine("Punkt leży w obrębie koła");
}
else
{
    Console.WriteLine("Punkt jest poza obrębem koła");
}