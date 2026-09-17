Console.WriteLine("Give me a number");
string input = Console.ReadLine();
long totalValue = 0;
for(int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i]))
    {
        continue;
    }
    for (int j = i + 1; j < input.Length; j++)
    {
        if (!char.IsDigit(input[j])) 
        { 
            break;
        }
        if (input[i] == input[j])
        {
            string placeHolder = input.Substring(i, j - i + 1);
            totalValue += long.Parse(placeHolder);

            for (int k = 0; k < input.Length; k++)
            {
                if (k >= i && k <= j) {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(input[k]);
            }
            Console.WriteLine();
            Console.ResetColor();
            break;
        }
    }
}
Console.WriteLine($"Total: {totalValue}");
Console.ReadKey();