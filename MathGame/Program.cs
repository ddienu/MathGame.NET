// See https://aka.ms/new-console-template for more information

using System.Collections;

var initialDate = DateTime.Now;
Console.WriteLine($"Initial time: {initialDate}");

Console.WriteLine("Welcome to the math game");
Console.WriteLine("");
Console.WriteLine("In this game, you will be able to perform basic operations such as addition, subtraction, multiplication, and division");
Console.WriteLine("");
Console.WriteLine("Next, on the screen, you will see the options depending on the operation you want to perform.");

var result = 0;
var resultsArray = new ArrayList();

String option;
String operation;

int timeElapsed = 0;

int number1 = 0;
int number2 = 0;

System.Timers.Timer stopWatch = new(1000);
stopWatch.Elapsed += (sender, e) =>
{
    timeElapsed++;
};

stopWatch.Start();

Console.WriteLine("To addition, type 'sum'");
Console.WriteLine("To subtraction, type 'subtract'");
Console.WriteLine("To multiplication, type 'multiply'");
Console.WriteLine("To division, type 'division'");
Console.WriteLine("To exit, type 'exit'");
Console.WriteLine("");
Console.WriteLine("You can view the history of the operations by typing 'history'");

do
{

    option = Console.ReadLine().ToLower();

    if (option != "history" && option != "exit")
    {
        Console.Write("Input the first number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Input the second number: ");
        number2 = int.Parse(Console.ReadLine());
    }

    switch (option)
    {
        case "sum":
            result = number1 + number2;
            Console.WriteLine($"{number1}  +  {number2} = {result}");
            operation = ($"{number1}  +  {number2} = {result}");

            resultsArray.Add(operation);
            Console.WriteLine("Type your next choice");
            break;
        case "subtract":
            result = number1 - number2;
            Console.WriteLine($"{number1}  -  {number2} = {result}");
            operation = ($"{number1}  -  {number2} = {result}");

            resultsArray.Add(operation);
            Console.WriteLine("Type your next choice");
            break;
        case "multiply":
            result = number1 * number2;
            Console.WriteLine($"The result between {number1}  *  {number2} = {result}");
            operation = ($"{number1}  *  {number2} = {result}");

            resultsArray.Add(operation);
            Console.WriteLine("Type your next choice");
            break;
        case "divition":
            result = number1 / number2;
            Console.WriteLine($"The result between {number1}  /  {number2} = {result}");
            operation = ($"{number1}  /  {number2} = {result}");

            resultsArray.Add(operation);
            Console.WriteLine("Type your next choice");
            break;
        case "history":
            Console.WriteLine("The results of the operations are:");

            foreach (var results in resultsArray)
            {
                Console.WriteLine(results);
            }
            if (resultsArray.Count == 0)
            {
                Console.WriteLine("There are no results in the history");
            }
            Console.WriteLine("Type your next choice");
            break;
        case "exit":
            stopWatch.Stop();
            Console.WriteLine($"Elapsed time: {timeElapsed} seconds");
            var finalDate = DateTime.Now;
            Console.WriteLine($"Final time: {finalDate}");
            break;
        default:
            Console.WriteLine("Incorrect option");
            break;
    }
} while (option != "exit");

