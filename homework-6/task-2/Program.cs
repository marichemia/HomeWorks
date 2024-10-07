

var str = "";
while (true)
{
 
    Console.WriteLine("enter a symbol or sequence, press x to exit:");
    var input = Console.ReadLine();
    
    if (input == "x")
    {
        break;
    } else
    {
        str = str + input;
       
    }

}



var numOfPairs = findPairs(str);

Console.WriteLine(numOfPairs);

static int findPairs(string str)
{

    char[] arr = str.ToCharArray();
    Array.Sort(arr);

    return arr.Where((a, b) => b < arr.Length - 1 && a == arr[b + 1]).Count();


}