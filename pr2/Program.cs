
using System.Security.AccessControl;

System.Console.WriteLine("please enter number");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
int[] array = new int[length];
for (var i = 0; i < length; i++)
{
  array[i] = number % 10;
  number = number / 10;

}
int flag = 0;
for (var i = 0; i < length; i++)
{
  if (array[i] != array[length - 1 - i])
  {
    System.Console.WriteLine("is not a palindrom number");
    flag = 1;
    break;

  }
}
if (flag == 0)
{
  System.Console.WriteLine("is a palindrom number");
}