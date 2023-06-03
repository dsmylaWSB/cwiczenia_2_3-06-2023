int NWD(int b, int d)  //NWD - największy wspólny dzielnik
{
    int pom;

    while (d != 0)
    {
        pom = d;
        d = b % d;
        b = pom;
    }
    return b;
}

int NWW(int b, int d)   //NWW - najmniejsza wspólna wielokrotność
{
    return (b * d) / NWD(b, d); ;
}
Console.WriteLine("\n\n    Wzór ogólny\n" +
                  $"    x   a   c  \n" +
                  $"    - = - + -  \n" +
                  $"    y   b   d  \n");
Console.Write($"    Podaj a: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"    Podaj b: ");
int b = int.Parse(Console.ReadLine());
Console.Write($"    Podaj c: ");
int c = int.Parse(Console.ReadLine());
Console.Write($"    Podaj d: ");
int d = int.Parse(Console.ReadLine());

if (b == 0||d==0)
{
    Console.WriteLine("Brak rozwiązania.");
    Environment.Exit(0);
}

Console.WriteLine("\n\n    dane\n" +
                  $"    x   {a}   {c}  \n" +
                  "    - = - + -  \n" +
                  $"    y   {b}   {d}  \n");

int wspolnyDzielnik = NWW(b, d);
int mnoznikB = wspolnyDzielnik / b;
int mnoznikD = wspolnyDzielnik / d;

a = a * mnoznikB;
c = c * mnoznikD;

Console.WriteLine("\n" +
                  $"    x   {a}   {c}  \n" +
                   "    - = - + -  \n" +
                  $"    y   {wspolnyDzielnik}   {wspolnyDzielnik}  \n");


int x = a + b;
int y = wspolnyDzielnik;

Console.WriteLine("\n" +
                  $"    {x}   {a}   {c}  \n" +
                   "    - = - + -  \n" +
                  $"    {y}   {wspolnyDzielnik}   {wspolnyDzielnik}  \n");

Console.WriteLine($"\n    {"x",-3} -> {x,3}" +
                  $"\n    {"y",-3} -> {y,3}");