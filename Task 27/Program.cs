//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число");
int A=Convert.ToInt32(Console.ReadLine());
int res=0;
for (int i=1; A > 0; i++)
{
    res=res+A%10;
    A=A/10;
}
Console.WriteLine(res);
