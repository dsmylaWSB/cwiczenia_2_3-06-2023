Console.WriteLine("Wprowadź trzy wartości a, b i c");

Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

double srednia = (a + b + c) / 3;
Console.WriteLine($"Średnia a, b i c wynosi {srednia}");

