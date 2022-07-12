// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
}

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return;

    PrintNaturalNumbers(numberM, numberN-1);
    
    if (numberN % 2 == 0)
    
    System.Console.Write($"{numberN}; ");
}

int numberM = Prompt("Введите первое число: ");
int numberN = Prompt("Введите второе число: ");

System.Console.WriteLine();

System.Console.Write($"M = {numberM}, N = {numberN} -> ");
PrintNaturalNumbers(numberM, numberN);
System.Console.WriteLine();