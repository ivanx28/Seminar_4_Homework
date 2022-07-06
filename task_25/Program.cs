// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double powerNumber(int x, int y)
{
    double power = Math.Pow(x, y);
    return power;
}

Console.WriteLine("Введите число A и число B");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число A возведённое в степень B равняется: " + powerNumber(numA, numB));