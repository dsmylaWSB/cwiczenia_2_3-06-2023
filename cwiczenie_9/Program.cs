//Najłatwiej i najbardziej poprawnie byłoby użyć dodatkowej zmiennej tymczasowej, jednak polecenie tego zabrania

Console.WriteLine("Podaj pierwszą liczbę: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj trzecią liczbę: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine("Przed zamianą \n a= " + a + " b= " + b + " c= " + c);

// Przechowujemy sumę wszystkich w a
a = a + b + c;

// Wartość a przenosimy do zmiennej b
b = a - (b + c);

// Wartość b przenosimy do zmiennej c
c = a - (b + c);

// Wartość c przenosimy do zmiennej a
a = a - (b + c);

Console.Write("Po zamianie \n a= " + a + " b= " + b + " c= " + c);