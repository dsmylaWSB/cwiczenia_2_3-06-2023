
Console.Write($"Wybierz działanie: \r\n1 - dodawanie \r\n2 - odejmowanie \r\n3 - mnożenie \r\n4 - dzielenie \r\n");
String dzialanie = Console.ReadLine();

Console.WriteLine("Podaj pierwszą liczbę: ");
double liczba1 = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double liczba2 = double.Parse(Console.ReadLine());

switch (dzialanie)
{
    case "1":
        double wynik = liczba1 + liczba2;
        Console.WriteLine("Suma wynosi " + wynik);
        break;

    case "2":
        double roznica = liczba1 - liczba2;
        Console.WriteLine("Różnica wynosi " + roznica);
        break;

    case "3":
        double iloczyn = liczba1 * liczba2;
        Console.WriteLine("Iloczyn wynosi " + iloczyn);
        break;

    case "4":
        double iloraz = liczba1 / liczba2;

        if (liczba2 == 0)
            Console.WriteLine("Iloraz wynosi \n " + liczba1 + "\n - \n 0");
        else
            Console.WriteLine("Iloraz wynosi " + iloraz);
        break;

    default:
        Console.WriteLine("Opcja " + dzialanie + " nie istnieje");
        break;
}

//mógłbym polecenia zawarte w linijkach 5-8 zawrzeć osobno w każdym case, aby ewentualny błąd o błędnie wpisanej operacji wyskoczył od razu
//natomiast znacznie wydłużałoby to program, więc zdecydowałem się tego nie robić