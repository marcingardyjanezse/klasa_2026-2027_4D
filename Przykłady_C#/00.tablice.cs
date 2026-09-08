int[] numerki = new int[10];

Console.WriteLine("Podaj ile chcesz liczb");
int ilosc = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj te liczby:");
for (int i = 0; i < ilosc; i++)
{
    numerki[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Podałeś takie liczby:");
for (int i = 0; i < ilosc; i++)
{
    Console.WriteLine(numerki[i]);
}


