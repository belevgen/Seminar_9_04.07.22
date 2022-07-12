// See https://aka.ms/new-console-template for more information

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

