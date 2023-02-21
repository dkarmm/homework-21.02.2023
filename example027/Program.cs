// Задача 27: Напишите метод, который принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber ()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int GetResult (int number)
{
    int result = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        result = result + lastDigit;
        number /= 10;
    }
    return result;
}
int result = GetResult(GetNumber());
Console.WriteLine(result);