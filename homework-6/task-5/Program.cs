//task 5

Console.WriteLine("Enter a number:");
var input = Console.ReadLine();

ReadDigits(input);

static void ReadDigits (string num) { 

    var converted = Convert.ToInt32(num);

    if (converted > 0 && num.Length == 1) 
    {
        Console.WriteLine(num);
        return; 
    }  else if (converted < 0){
        Console.WriteLine("Invalid Parameter");
        return;
    }

    Console.WriteLine(num[0]);
    ReadDigits(num.Substring(1));


}