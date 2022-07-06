// Программа, которая задаёт массив длинной заданной пользователем, из элементов введённых пользователем
// с последующим отображением массива.

void fillArray (int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
        {
            Console.WriteLine("Введите элемент массива под индексом " + index);
            arr[index] = Convert.ToInt32(Console.ReadLine());
        }
}

Console.WriteLine("Введите длинну необходимого массива");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];  // Если нужна заданная длинна, а не введённая пользователем, то удаляем две предыдущие строки кода, а в этой просто пишем цифру, вместо переменной x.

fillArray(array);

Console.WriteLine();
Console.WriteLine("Массив элементы которого вы ввели:");
Console.Write("[ ");
Console.Write(string.Join(" | ", array));
Console.WriteLine(" ]");