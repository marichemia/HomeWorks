//task 4

List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
List<string> strList = new List<string> { "this", "is", "a", "random", "text" };
List<bool> boolList = new List<bool> { true, false, true, true, false };


var intResult = checkListType(intList);
Console.WriteLine(intResult);
var strResult = checkListType(strList);
foreach (var item in strResult)
{
    Console.WriteLine(item);
}
var boolRes = checkListType(boolList); 
Console.WriteLine(boolRes);


static dynamic checkListType<T>(List<T> list)
{
    if (typeof(T) == typeof(int))
    {
        var count = 0;
        foreach (var item in list)
        {
     
            count = count + Convert.ToInt32(item);

        }

        return count;

    } else if (typeof(T) == typeof(string))
    {

        var stringList = list.ConvertAll(item => item.ToString().ToUpper());

        return stringList;

    } else if (typeof(T) == typeof(bool))
    {
        var length = Convert.ToDouble(list.Count);
        var middle = Convert.ToInt32(Math.Ceiling(length / 2));
            return $"first value: {list[0]}, last value: {list[list.Count-1]}, middle value: {list[middle]}";
    } else
    {
        Console.WriteLine("invalid type");
            return 0;
    }

}
