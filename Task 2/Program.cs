// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
}

int PrintSum1Numbers(int numberM, int numberN)
{
    if (numberM > numberN) return 0;

    return PrintSum1Numbers(numberM, numberN-1) + numberN;
}

int numberM = Prompt("Введите первое число: ");
int numberN = Prompt("Введите второе число: ");

System.Console.WriteLine();

int a = PrintSum1Numbers(numberM, numberN);
System.Console.WriteLine($"Произведение натуральных чисел от {numberM} до {numberN} равняется {a}" );

