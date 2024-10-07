
// Task 1
Console.WriteLine("------Task 1------");
Console.WriteLine("Please enter a number:");

var num = Console.ReadLine();
var convertNum = Convert.ToInt32(num);

if (convertNum % 5 == 0)
{
    Console.WriteLine("IS divisible by 5");
} else
{
    Console.WriteLine("is NOT divisible by 5");
}





//Task 2
Console.WriteLine("------Task 2------");



Console.WriteLine("Enter 1st number:");
var num1 = Console.ReadLine();
var convertedNum1 = Convert.ToDouble(num1);

Console.WriteLine("Enter 2nd number:");
var num2 = Console.ReadLine();
var convertedNum2 = Convert.ToDouble(num2);


var sum = convertedNum1 + convertedNum2;
Console.WriteLine($"{num1} + {num2} = {sum}");


var product = convertedNum1 * convertedNum2;
Console.WriteLine($"{num1} * {num2} = {product}");


double difference;
if (convertedNum1 >= convertedNum2)
{
    difference = convertedNum1 - convertedNum2;
    Console.WriteLine($"{num1} - {num2} = {difference}");

} else
{
    difference = convertedNum2 - convertedNum1; 
    Console.WriteLine($"{num2} - {num1} = {difference}");
}

double quotient;
if (convertedNum2 >= convertedNum1 && convertedNum1 != 0)
{

    quotient = convertedNum2 / convertedNum1;
    Console.WriteLine($"{num2} / {num1} = {quotient}");

} else if (convertedNum2 < convertedNum1  && convertedNum2 != 0)
{
    quotient= convertedNum1 / convertedNum2;
    Console.WriteLine($"{num1} / {num2} = {quotient}");

} else
{
    Console.WriteLine("Cannot divide by 0");
}




//Task 3
Console.WriteLine("------Task 3------");

Console.WriteLine("First Number:");
var firstNum = Console.ReadLine();

Console.WriteLine("Second Number:");
var secondNum = Console.ReadLine();

var copyFirstNum = firstNum;
firstNum = secondNum;
secondNum = copyFirstNum;

Console.WriteLine($"First number: {firstNum}, Second number: {secondNum}");




//Task 4
Console.WriteLine("------Task 4------");

Console.WriteLine("Enter a Number:");
var number = Console.ReadLine();
var convertedNumber = Convert.ToInt32(number);

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{convertedNumber} * {i} = {convertedNumber * i}");
}




//Task 5
Console.WriteLine("------Task 5------");

Console.WriteLine("Enter a Number:");
var input = Console.ReadLine();
var convertedInput = Convert.ToInt32(input);

for(int i = 1; i < convertedInput; i++)
{
    if (i % 2 == 0) Console.WriteLine(i * i);
}







