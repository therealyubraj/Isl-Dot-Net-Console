using System;
using ConsoleApp.Calculator;
using ConsoleApp.Week2;


Console.Write("Press 1 for if else, \n" +
    "2 for switch case, \n" +
    "3 for do while loop, \n" +
    "4 for for loop \n" +
    "5 for each loop: ");

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
    default:
        Console.WriteLine("Invalid input.");
        break;
}