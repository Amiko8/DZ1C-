//Напишите программу, оторая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i % 2 == 0)

        Console.WriteLine(i);
