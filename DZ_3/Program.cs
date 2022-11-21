/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите неотрицательнoe число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите неотрицательнoe число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int FindFunctionAckerman(int m, int  n)
{
    if (m==0)
        return n+1;
    else
        if ((m!=0) && (n==0))
            return FindFunctionAckerman(m-1,1);
        else
            return FindFunctionAckerman(m-1,FindFunctionAckerman(m,n-1));
}
Console.WriteLine($"A({m},{n}) -> {FindFunctionAckerman(m,n)}");