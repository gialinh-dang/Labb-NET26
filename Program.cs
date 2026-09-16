Console.ForegroundColor = ConsoleColor.White; 
Console.Write("Skriv in en sträng: ");
string text = Console.ReadLine();

// t.e.x: 29535123p48723487597645723645

Console.WriteLine();

long total = 0;

for(int x = 0; x < text.Length; x++)
{
    if (char.IsDigit(text[x]))
    {
        for(int y = x+1; y < text.Length; y++)
        {
            if (!char.IsDigit(text[y]))
            {
                break;
            }
            if (text[x] == text[y])
            {
                string nummer = text.Substring(x, y - x + 1);

                Console.Write(text.Substring(0, x));
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.Write(nummer);
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(text.Substring(y + 1));

                total = total + long.Parse(nummer);

                break;
            }
        }
    }
}
Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Total: {total}");

Console.WriteLine();