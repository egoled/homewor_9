// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int RecursiveMToNSum(int M, int N)
{
    int total = 0;
    if (N < M)
    {
        return 0;
    }
    else
    {
        {
            total = M + RecursiveMToNSum(M + 1, N);
            return total;

        }
    }

}

int Prompt(string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

int m = Prompt("Введите M");
int n = Prompt("Введите N");
System.Console.WriteLine(RecursiveMToNSum(m, n));