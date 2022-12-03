// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number ");

int num =int.Parse(Console.ReadLine());
int num2 = 0;
int num3 = 0;

while (num >= 1000)
{
    num = num / 10;
}
if ((num >= 100) && (num < 1000))    
{
    num2 = num % 100;
    num3 = num2 % 10;
    Console.WriteLine(num3);
}
else
{
    Console.WriteLine("третьего числа нет");
}