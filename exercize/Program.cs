int n = 3;
int size = 6;
string[] arrayFirst = new string[size];
Console.WriteLine($"Введите наборов символов, означающих значение строкового элемента массива, {size} раз через enter без пробелов");
FillArray(arrayFirst);
Console.Clear();
PrintArray(arrayFirst);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}:");
if (GetSizeOfSecondArray(arrayFirst) == 0) {Console.WriteLine("искомых элементов строкового массива для переноса в новый массив нет");}
else
{
    string[] arraySecond = TransferElements(arrayFirst);
    PrintArray(arraySecond);
}

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrLeng; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSizeOfSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] TransferElements(string[] arr)
{
    string[] arraySecond = new string[GetSizeOfSecondArray(arrayFirst)];
    for (int i = 0, j = 0; i < size; i++)
    {
    if (arr[i].Length <= n)
    {
        arraySecond[j] = arr[i];
        j++;
    }
}
return arraySecond;
}