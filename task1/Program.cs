int a = -9;
int b = -3;

int max = a;
int min = a;

if (a > max) max = a;
if (a < max) min = a;

if (b > max) max = b;
if (b < max) min = b;

Console.Write ("max= ");
Console.WriteLine(max);

Console.Write ("min= ");
Console.WriteLine(min);