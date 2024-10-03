//task 4

int[] hoursPerDays = new int[7];
var payroll = 0;

for (int i = 0; i < hoursPerDays.Length; i++)
{
    Console.WriteLine($"Enter hrs worked on day {i+1}");

    var hrs = Convert.ToInt32(Console.ReadLine());

    if ( hrs > 8 )
    {
        payroll += hrs * 15;
    } else if (i > 4)
    {
        payroll += hrs * 2 * 10;
    } else
    {
        payroll += hrs * 10;
    }
    
}

Console.WriteLine($"Your total: {payroll}");
