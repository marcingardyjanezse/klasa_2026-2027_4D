int[] numerki;

Console.WriteLine("Podaj ile chcesz liczb:");
int ilosc = int.Parse(Console.ReadLine());

numerki = new int[ilosc];

Console.WriteLine("Podaj te liczby:");

for (int i = 0; i < ilosc; i++)
{
    numerki[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Podałeś następujące liczby:");

for (int i = 0; i < ilosc; i++)
{
    Console.WriteLine(numerki[i]);
}

