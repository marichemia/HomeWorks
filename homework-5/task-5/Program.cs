//task 5

Console.WriteLine("Enter number of days in training:");
int numOfDays = Convert.ToInt32(Console.ReadLine());

int[] hrsPerday = new int[numOfDays];
int length = 0;
int maxLength = 0;

for (int i = 0; i < numOfDays; i++)
{
    Console.WriteLine($"Enter hours trained on day {i+1}");
    hrsPerday[i] = Convert.ToInt32(Console.ReadLine());


    if ( i > 0 && hrsPerday[i-1] < hrsPerday[i] )
    {
        length++;
    } else
    {
        length = 0;
    }


    if (length > maxLength)
    {
        maxLength = length;
    }


}

Console.WriteLine($"Your Streak: {(maxLength> 0? maxLength+1 : maxLength)} days.");  