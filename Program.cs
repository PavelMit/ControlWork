/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

//метод для ипечати массива строк
void PrintArray(string[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        i++;
    }
}

//основной метод, генерирующий нужный массив строк не длиннее 3 символов
string[] LeaveLessThanFourSigns(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4) counter++;

    string[] result = new string[counter];
    int i2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[i2] = array[i];
            i2++;
        }
    }
    return (result);
}

//формируем исходный массив c учетом ввода отрицательных чисел
int size = 0;
while (size < 1)
{
    Console.Write("Please input positive quantity of string: ");
    size = Convert.ToInt32(Console.ReadLine());
}

string[] newArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Please input {i+1} string: ");
    newArray[i] = Console.ReadLine();
}

//проверяем
PrintArray(LeaveLessThanFourSigns(newArray));

