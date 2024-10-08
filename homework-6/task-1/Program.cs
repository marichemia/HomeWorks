
//task 1

Console.WriteLine("min number:");
var min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max number:");
var max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter n:");
var pow = Convert.ToInt32(Console.ReadLine());

var list = findNumber(min ,max, pow);

Console.WriteLine($"there are {list.Count} nums that raised to the power of {pow} are between {min} and {max}");
foreach (var item in list)
{
    Console.WriteLine(item);
}


static List<int> findNumber(int a, int b, int n) {

    var start = Convert.ToInt32(Math.Ceiling(Math.Pow(a, 1.0 / n)));
    var end = Convert.ToInt32(Math.Floor(Math.Pow(b, 1.0 / n)));
    int num;

    List<int> result = new List<int>();

    for (var i = start; i <= end; i++)
    {
        num = i;
        result.Add(num);
    }

    return result;

}