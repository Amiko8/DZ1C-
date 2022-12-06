
Console.Write("Введите число  ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);

if (value % 2 ==1)
{
    System.Console.WriteLine("Число " + value + " является нечётным");
}
else
{
   System.Console.WriteLine("Число " + value + " является чётным"); 
}

