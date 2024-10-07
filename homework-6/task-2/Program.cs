//task 2

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
    var count = 0;


    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] == arr[i+1])
        {
            count++;
            i++;
        }
    }

    return count;


}
