Dictionary<string, string> ksiazkaTelefoniczna
    = new Dictionary<string, string>();

ksiazkaTelefoniczna["Franciszek Nowak"] = "888-123-643";
ksiazkaTelefoniczna["Jan Kowalski"] = "234-123-645";
ksiazkaTelefoniczna["Grzegorz Kowalski"] = "132-563-623";

if (ksiazkaTelefoniczna.ContainsKey("Jan Kowalski"))
{
    Console.WriteLine("Jest");
}
else
{
    Console.WriteLine("Nie Jest");
}

string szukanyTel;
if (ksiazkaTelefoniczna.TryGetValue("Jan Kowalski", out szukanyTel))
{
    Console.WriteLine("Znaleziono " + szukanyTel);
}

foreach (var p in ksiazkaTelefoniczna)
{
    Console.WriteLine(p.Key + ": " + p.Value);
}



