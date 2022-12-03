using System;
using ConsoleApp.Calculator;
using ConsoleApp.Week2;
using ConsoleApp.Week3;

do
{
    Console.Write("Press 1 for if else, \n" +
        "2 for switch case, \n" +
        "3 for do while loop, \n" +
        "4 for for loop \n" +
        "5 for each loop: \n" +
        "6 for prime \n" +
        "7 for even \n" +
        "8 for swap \n" +
        "9 for search string: ");

    var userChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a number: ");
    var num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number: ");
    var num2 = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            SelectStatement.IfElse();
            break;
        case 2:
            SelectStatement.SwitchCase();
            break;
        case 3:
            IterationStatement.DoWhile(num1);
            break;
        case 4:
            IterationStatement.ForLoop();
            break;
        case 5:
            IterationStatement.ForEachLoop();
            break;
        case 6:
            Console.WriteLine(Questions.isPrime(num1));
            break;
        case 7:
            Console.WriteLine(Questions.isEven(num1));
            break;
        case 8:
            Questions.swapValues(num1, num2);
            break;
        case 9:
            string[] arr = { "a", "b", "c", "d" };
            Console.Write("Enter a,b,c,d");
            var s = Console.ReadLine();
            Console.WriteLine($"The string {s} is at index {Questions.searchString(s, arr)}");
            break;
        default:
            Console.WriteLine("Invalid input.");
            break;
    }
    Console.Write("Do u want to quit? ");

} while (Console.ReadLine().ToLower() != "y");

