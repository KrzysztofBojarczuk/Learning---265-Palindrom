// See https://aka.ms/new-console-template for more information

string[] tablica = { "abba", "deska" };

foreach (var item in tablica)
{
    Console.WriteLine(Check(item));
}


static bool Check(string text)
{
    if (string.IsNullOrWhiteSpace(text))
    {
        return false;
    }

    text = text.Replace(" ", "").ToLower();

    return text == new string(text.ToCharArray().Reverse().ToArray());
}
