// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumberA()
{
    Console.Write("Введите число А: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int GetNumberB()
{
    Console.Write("Введите число B: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int GetResult(int numberA, int numberB)
{
    int result = 1;
    for (int count = 0; count < numberB; count++)
    {
        result = result * numberA;
    }
    return result;
}

int result = GetResult(GetNumberA(), GetNumberB());
Console.WriteLine(result);

