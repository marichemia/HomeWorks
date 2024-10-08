//task 3

using System.ComponentModel.Design;

Console.WriteLine("Enter the 1st word:");
var firstStr = Console.ReadLine();
Console.WriteLine("Enter the 2nd word:");
var secondStr = Console.ReadLine();

var result = findCommonEnding(firstStr, secondStr);
Console.WriteLine(result);

static string findCommonEnding(string str1, string str2)
{

    var str1Reversed = ReverseString(str1);
    var str2Reversed = ReverseString(str2);
    var count = 0;
    var commonEnding = "";
    int maxLength;

    maxLength = str1.Length < str2.Length ? str1.Length : str2.Length;


    while ( count<maxLength && str1Reversed[count] == str2Reversed[count])
    {
        
        commonEnding += str1Reversed[count];
        count++;

    } 
    return ReverseString(commonEnding);

}

static string ReverseString (string str)
{
    char[] charArr = str.ToCharArray(); 
    Array.Reverse(charArr); 
    return new string(charArr);
}