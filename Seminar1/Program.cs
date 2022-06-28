/* 
int num1, num2; // Задача №2

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int max = num1, min = num1;

if(num2 > max) max = num2;
{
    Console.WriteLine("Max number " + max);
}

if(num2 <= min)  min = num2;
{
    Console.WriteLine("Min number " + min);
}
*/

/*
int num1, num2, num3; // Задача №4

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;

if(num3 > max) max = num3;
{
    Console.WriteLine("Max number " + max);
}
*/
/*
int n; // Задача №6

Console.WriteLine("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine("Число является четным " + n);
}
else
{
    Console.WriteLine("Число является нечетным " + n);
}
*/

int n, current; //Задача №8

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = 2;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
    if(current % 2 == 0)
 
    if (current > n)
	{
		break;
	}
	current++;
}