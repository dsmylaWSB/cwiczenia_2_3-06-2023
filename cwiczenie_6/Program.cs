Console.WriteLine("Wprowadź długości boków trójkąta - a, b i c");

Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

if( a == b && b == c)
{
    Console.WriteLine("Z tych boków powstanie trójkąt równoboczny");
}
else if( a == c || b == c || a == b)
{
    Console.WriteLine("Z tych boków powstanie trójkąt równoramienny, ale nie równoboczny");
}
else
    Console.WriteLine("Z tych boków nie powstanie trójkąt równoboczny ani równoramienny");

//wiem że wystarczyło zrobić tylko if i else z równobocznym, ale uznałem że takie ubarwienie nie zaszkodzi
