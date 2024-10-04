//task 3

Console.WriteLine("Enter number of won matches:");
var win = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of tied matches:");
var tie = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of lost matches:");
var loss = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your team has a total of {win*3 + tie} points.");