int day;
Console.WriteLine("Please enter a number between 1 and 7");
try
{
    day = Convert.ToInt32(Console.ReadLine());

    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;

        case 2:
            Console.WriteLine("Tuesday");
            break;

        default:
            Console.WriteLine("I said......... 1- 7");
            break;

    }
}
catch
{
    Console.WriteLine("Incorrect Input");
}

Console.ReadKey();