List<int> numerki = new List<int>();

Console.WriteLine("Podaj ile chcesz liczb:");
int ilosc = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj te liczby:");

for (int i = 0; i < ilosc; i++)
{
    numerki.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Podałeś następujące liczby:");

for (int i = 0; i < ilosc; i++)
{
    Console.WriteLine(numerki[i]);
}

