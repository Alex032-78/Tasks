// Вывести квадрат числа

Console.Clear();
double a, sqrt=0;
string s;
Console.Write("Введите число, которое необходимо возвести в квадрат а=");
s=Console.ReadLine();
a=Convert.ToDouble(s);

sqrt=a*a;
System.Console.WriteLine("Квадрат заданного числа: {0}", sqrt);
