
//task 1

Console.WriteLine("Please enter length of the Radius:");

var radius = Convert.ToInt32(Console.ReadLine());

var s2 = Math.Pow(radius * 2, 2);
var s1 = s2 / 2;

Console.WriteLine($"Difference is {s2-s1}");

