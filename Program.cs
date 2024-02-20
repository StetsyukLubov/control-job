String[] CreateArray()
{
    Console.Write("Enter array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Enter {i + 1} array element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
string[] ResultArray(string[] array)
{
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) a += 1;
    }
    string[] arrayRes = new string[a];
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3)
        {
            arrayRes[b] = array[i];
            b += 1;
        }
    }
    return arrayRes;
}
string[] arrayFirst = CreateArray();
Console.WriteLine();
Console.WriteLine("Entered array: ");
ShowArray(arrayFirst);
Console.WriteLine();
string[] arrayResult = ResultArray(arrayFirst);
Console.WriteLine("Array result: ");
ShowArray(arrayResult);
