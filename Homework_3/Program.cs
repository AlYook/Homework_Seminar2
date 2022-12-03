// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter number week day ");
int day = int.Parse(Console.ReadLine());

if ((day > 7) || (day < 1))
{
    Console.WriteLine("Day of the week not found, please enter a valid day");
    return;
}
if ((day == 7) || (day == 6))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}