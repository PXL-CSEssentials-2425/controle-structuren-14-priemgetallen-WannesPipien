for (int number = 1; number <= 1000000; number++)
{
    bool isPrime = true;

    for (int check = 2; check <= number / 2; check++)
    {
        if (number % check == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    Console.Write($"{number}\t");
    Console.ResetColor();

    if (number % 10 == 0)
    {
        Console.WriteLine();
    }
}