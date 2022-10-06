int grade1, grade2, grade3, grade4, grade5, grade6;
int average;
char choice;
do
{
        try
        {
        Console.WriteLine("Enter Grade1");
        grade1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade2");
        grade2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade3");
        grade3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade4");
        grade4=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade5");
        grade5=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade6");
        grade6=Convert.ToInt32(Console.ReadLine());

        average = (grade1+grade2+grade3+grade4+grade5+grade6)/6;

            switch (average)
            {
                case >=70:
                    Console.WriteLine("1st");
                    break;

                case >=60:
                    Console.WriteLine("2:1");
                    break;

                default:
                    Console.WriteLine("Less than a 2:1");
                    break;

            }
        }
        catch
        {
            Console.WriteLine("Incorrect Input");
        }
        Console.WriteLine("Do you want to try again?");
        choice=Convert.ToChar(Console.ReadLine());
}while(choice != 'N');
Console.ReadKey();