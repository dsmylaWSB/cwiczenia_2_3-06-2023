// Nie byłem do końca pewny, co oznaczało "Wykorzystując dzielenie całkowite" w poleceniu

//Użyłem operatora modulo - x % y. Zwraca on resztę z dzielenia x przez y
//Dzieląc wprowadzoną liczbę naturalną n przez 10 otrzymuję resztę z tego dzielenia, czyli ostatnią cyfrę

Console.WriteLine("Wpisz dowolną liczbę naturalną:");
int n = int.Parse(Console.ReadLine());  //w wypadku działania na dużych liczbach zamiast "int" można użyć "len"

if (n > 0)
{
    int ostatniaCyfra = n % 10;
    Console.WriteLine("Ostatnią cyfrą liczby {0} jest: {1}", n, ostatniaCyfra);
}
else
{
    Console.WriteLine(n + " nie jest liczbą naturalną"); 
}

//dodałem w funkcji warunkowej zabezpieczenie na wypadek gdyby użytkownik wprowadził ujemną liczbę całkowitą
//bez tego program zadziałałby, ale zwróciłby wartość ostatniej cyfry z minusem