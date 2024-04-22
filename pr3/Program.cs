using System;
System.Console.WriteLine("please enter number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
if (sum % 9 == 0)
{
    System.Console.WriteLine("is divisible by 9");
}
else
{
    System.Console.WriteLine("is not divsible by 9");
}