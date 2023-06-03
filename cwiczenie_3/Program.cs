Console.WriteLine("Wprowadź swój wzrost i wagę: ");

Console.Write("waga [kg] = ");
double w = Convert.ToDouble(Console.ReadLine());

Console.Write("wzrost [m] = ");
double h = Convert.ToDouble(Console.ReadLine());

double BMI = w / (Math.Pow(h,2));
Console.WriteLine($"Twoje BMI wynosi {BMI}");