// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt (string message)
{
    Console.Write(message);
    string a_string = Console.ReadLine ();
    return int.Parse(a_string);

}

void PrintNatNumber (int numM, int numN)
{
    if (numM > numN) return;
    if (numN % 2 == 1)
    {
        numN--;
    }
    PrintNatNumber (numM, numN-2);
    System.Console.Write($"{numN}; ");
}

int numM = Prompt ("Введите число 1: ");
int numN = Prompt ("Введите число 2: ");
Console.WriteLine();
Console.Write($"M = {numM}, N = {numN} > ");
PrintNatNumber(numM, numN);
Console.WriteLine();