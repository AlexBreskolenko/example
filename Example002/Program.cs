Console.Clear();

//Создаем массив
int[] array = {5, 3, 6, 11, 5, 45, 13};

//Флаг найдено число иль нет
bool flag = true;

//Длинна массива
int arraySize = array.Length;

//Просим ввети искомое число
Console.Write("Введите искомое число : ");
string str = Console.ReadLine();

//Конвертируем его
int numberDesired;
numberDesired = Convert.ToInt32(str);

//Проходимся по массиву
for (int i = 0; i < arraySize; i++)
{
    //если нашли его то выводим и прекращаем цикл
    if (array[i] == numberDesired)
    {
        Console.WriteLine(array[i]);
        flag = false;
        break;
    }
}

//Если не нашли число выведем об этом
if(flag)
{
    Console.Write("Искомого числа нет в массиве !");
}
