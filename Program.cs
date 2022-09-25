/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine ("введите число от 1 до 7");  
int day = Convert.ToInt32(Console.ReadLine()); 
if (day < 6 && day > 0)
{ 
    Console.WriteLine($"число {day} не является выходным"); 
} 
else if (day > 5 && day < 8)
{ 
        Console.WriteLine($"число {day} является выходным днем"); 
}
else
{
    Console.WriteLine($"число {day} является днем недели"); 
}
