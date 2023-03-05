int a = 3;
int b = 6;
int c = 1;
int d = 8;
int f = 2;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.Write ("max = ");
Console.WriteLine(max);