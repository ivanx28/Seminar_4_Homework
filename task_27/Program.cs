// Программа, которая принимает на вход число и выдаёт сумму цифр в числе (с помощью рекурсии).

int sumNumbers(int num)
{
    if (num < 10)
        return num;
    else
        return (num%10)+sumNumbers(num/10);
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Сумма цифр в введёном числе равняется: " + sumNumbers(number));