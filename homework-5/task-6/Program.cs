//task 6

string[] arr = { "Hello", "world", "programming", "communication" };

Console.WriteLine("Enter a number:");
int minLength = Convert.ToInt32(Console.ReadLine());

var filteredArr = arr.Where(word => word.Length >= minLength);

foreach (var word in filteredArr)
{
    Console.WriteLine(word);
}
