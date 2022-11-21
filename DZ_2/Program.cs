/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите цело число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите цело число N: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write($"M = {m}; N = {n} -> {SumNaturals(m, n)}");

int SumNaturals(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (start + SumNaturals(start + 1, end));
}