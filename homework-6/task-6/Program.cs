//task 6

using System.Collections.Immutable;

List<int> list = new List<int>();

while (true)
{ 
    Console.WriteLine("Enter numbers, press 'x' to exit:");
    var input = Console.ReadLine();

    if (input == "x")
    {
        break;
    }

    list.Add(Convert.ToInt32(input));

}

var result = HasDuplicates(list.ToArray());
Console.WriteLine(result);

static bool HasDuplicates(int[] arr)
{
    return arr.GroupBy(n => n).Any(g => g.Count() > 1);
}
