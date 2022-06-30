/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввестии с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] CreateArray(int size) //Создание массива
{
    return new string[size];
}
void FillArray(string[] array) //Наполнение массива рандомными числами
{
    for(int i = 0; i < array.Length; i++)
    {
        int random = new Random().Next(-999, 9999);
        array[i] = $"{random}";
    }
}
string PrintArray(string[] array) //Для печати массива
{
    string text = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        text = text + $"{array[i]} "; 
    }
    return text;
}

string[] MainTask(string[] inputArray) //Решение задачи
{
    int size = inputArray.Length;
    int i = 0;
    int index = 0;
    while(i < size)
    {
        string elementLength = inputArray[i];
        if(elementLength.Length <= 3)
        {
            index++;
        }
        i++;
    }
    string[] outputArray = new string[index];
    index = 0;
    i = 0;
    while(i < size)
    {
        string elementLength = inputArray[i];
        if(elementLength.Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }
    return outputArray;
}


Console.WriteLine("Size of massive: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Hand input(1) or random massive(2)?");
int choose = int.Parse(Console.ReadLine());
if(choose == 1)
{
    string[] inputArray = CreateArray(size);
    for(int i = 0; i < size; i++)
    {
        inputArray[i] = Console.ReadLine();
    }
    Console.WriteLine("Your array:");
    Console.Write(PrintArray(inputArray));
    Console.WriteLine();
    Console.WriteLine();
    string[] outputArray = MainTask(inputArray);
    
    if(outputArray.Length == 0)
    {
        Console.WriteLine("New array is empty");
    }
    else 
    {
        Console.WriteLine("New array:");
        Console.Write(PrintArray(outputArray));
    }
}
else if(choose == 2)
{
    string[] inputArray = CreateArray(size);
    FillArray(inputArray);
    Console.WriteLine("Random array:");
    Console.Write(PrintArray(inputArray));
    Console.WriteLine();
    Console.WriteLine();
    string[] outputArray = MainTask(inputArray);
    
    if(outputArray.Length == 0)
    {
        Console.WriteLine("New array is empty");
    }
    else 
    {
        Console.WriteLine("New array:");
        Console.Write(PrintArray(outputArray));
    }
}
else Console.WriteLine("Input error");

