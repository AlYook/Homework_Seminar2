// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number ");

string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if (enterNum.Length == 3)
{
    int num2 = num % 100;

    Console.WriteLine($"{num2 / 10}");
}
else 
{
   Console.WriteLine("Invalid number. Enter a three-digit number");
}
