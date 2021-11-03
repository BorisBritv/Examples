int a = 1;
int b = 2;
int c = 4;
int d = 2;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);