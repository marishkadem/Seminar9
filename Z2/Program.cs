/* Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт 
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
 int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    
    return m + SumNumbers(m + 1, n);
    
  
}

int m = Prompt("Введите первое число >");
int n = Prompt("Введите второе число >");
Console.Write($" Сумма цифр равна {SumNumbers(m,n)}");