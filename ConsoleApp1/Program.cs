// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a string: ");
var input = Console.ReadLine();
input = input.ToLower();

int forward = 0;
int backward = input.Length - 1;

for (; forward <= backward; forward++, backward--)
{
    if (input[forward] != input[backward])
    {
        break;
    }
}

if (forward > backward)
{
    Console.WriteLine("Palidrom");
}
else
{
    Console.WriteLine("Not plaindrom");
}



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
