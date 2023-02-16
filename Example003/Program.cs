Console.Clear();

//Создаем функцию для заполнения ее рандомными числами 
void fillArray(int[] arr)
{
    int arrSize = arr.Length;

    for (int index = 0; index < arrSize; index++)
    {
        arr[index] = new Random().Next(1, 50);
    }
}
//Функция для вывода массива
void printArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ,");
    }
}

//Функция принимает массив и число, и возвращает индекс этого числа
int indexDesiredNum(int[] arr, int number)
{

    int indDesired = -1;

    for (int index = 0; index < arr.Length; index++)
    {
        if (number == arr[index])
        {
            indDesired = index;
            break;
        }
    }

    return indDesired;
}

//Создаем массив на 10 чисел
int[] array = new int[10];

//Заполняем массив рандомными числами
fillArray(array);
//Выводим массив
printArray(array);

Console.WriteLine();
Console.Write("Введите число : ");
string str = Console.ReadLine();

int numInput = Convert.ToInt32(str);

Console.Write("Index = " + indexDesiredNum(array, numInput));