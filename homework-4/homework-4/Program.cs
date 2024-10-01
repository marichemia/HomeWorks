//Task 1

using System.ComponentModel.Design;
using System.Text.RegularExpressions;

Console.WriteLine("-----task 1-----");
Console.WriteLine("Enter a number:");

var input = Console.ReadLine();
var length = Convert.ToInt32(input);

int[] arr = new int[length];

for (int i = 0; i < length;  i++)
{
    arr[i] = i + 1;

}

List<int> evenNums = new List<int>();
List<int> oddNums = new List<int>();

for (int i = 0; i < length; i++)
{
    if (arr[i] % 2 == 0)
    {
        evenNums.Add(arr[i]);
    } else
    {
        oddNums.Add(arr[i]);
    }
}

int[] evenArr = evenNums.ToArray();
int[] oddArr = oddNums.ToArray();

Console.WriteLine("Even numbers: " + string.Join(", ", evenArr));
Console.WriteLine("Odd numbers: " + string.Join(", ", oddArr));




//Task 2

Console.WriteLine("-----task 2-----");
Console.WriteLine("Choose an action: Add, Delete or Update");
Console.WriteLine("Press 'X' to quit");

var action = Console.ReadLine().ToLower();

Dictionary<string, string> contacts = new Dictionary<string, string>();

string searchKey;
string searchValue;
bool contactExists;


while (action != "x" )
{

    if (action == "add")
    {

        Console.WriteLine("Enter a Name:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter a Number:");
        var number = Console.ReadLine();

        contacts.Add(name, number);

        Console.WriteLine("Contact Saved!");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact.Key + " " + contact.Value);
        }

        Console.WriteLine("Choose an action: Add, Delete or Update");
        Console.WriteLine("Press 'X' to quit");

        action = Console.ReadLine().ToLower();

    }
    else if (action == "delete")
    {
        Console.WriteLine("Enter a name:");
        searchKey = Console.ReadLine();

        if (contacts.ContainsKey(searchKey))
        {
            contacts.Remove(searchKey);
            Console.WriteLine("Contact Deleted!");


            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Key + " " + contact.Value);
            }
        } else
        {
            Console.WriteLine("Contact Not Found");
        }


        Console.WriteLine("Choose an action: Add, Delete or Update");
        Console.WriteLine("Press 'X' to quit");

        action = Console.ReadLine().ToLower();


    }
    else if (action == "update")
    {

        Console.WriteLine("Enter a Name:");
        searchKey = Console.ReadLine();

        if (contacts.ContainsKey(searchKey))
        {

            Console.WriteLine("Enter New Number:");
            contacts[searchKey] = Console.ReadLine();

            Console.WriteLine("Info updated!");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Key + " " + contact.Value);
            }

        } else
        {
            Console.WriteLine("Contact Not Found!");

        }


        Console.WriteLine("Choose an action: Add, Delete or Update");
        Console.WriteLine("Press 'X' to quit");

        action = Console.ReadLine().ToLower();


    }
    else if (action == "X")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid action");
    }



}


//Task 3

Console.WriteLine("-----task 3-----");

Console.WriteLine("Enter Your Number Sequence:");

var inputNums = Console.ReadLine();




