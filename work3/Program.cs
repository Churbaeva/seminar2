// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Enter the number of the day of the week");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}