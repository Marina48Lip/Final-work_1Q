/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.*/

// ввод массива с клавиатуры
string[] array = new string[4];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i}-й элемент массива " );
    array[i] = Console.ReadLine();
}
Console.WriteLine("Вы ввели массив: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}


//формируем новый массив длиной строк меньше либо равно 3
string[] array2 = new string[array.Length];
void NewArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}

//вывод нового массива на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
NewArray(array, array2);
Console.WriteLine();
Console.WriteLine("Массив с длиной строк менее либо равно 3:");
PrintArray(array2);
