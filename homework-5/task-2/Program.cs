//task 2

Console.WriteLine("Please enter the length of your sequence:");

var length = Convert.ToInt32(Console.ReadLine());
char[] chars = new char[length];
bool allEqual;

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter a character:");
    var input = Console.ReadLine();

    chars[i] = input[0];

}

allEqual = chars.All(a => a == chars[0]);

Console.WriteLine(allEqual ? "You Won!" : "Better luck next time!");
