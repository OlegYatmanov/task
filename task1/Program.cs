using System;
Console.Clear();
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

if(B * B == A)
{
    Console.WriteLine("А является квадратом B");
}
else
{
   Console.WriteLine("А не является квадратом B"); 
}