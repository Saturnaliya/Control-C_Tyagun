// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


int n = 4;
int size = 9;
string[] arrayOne = new string[size];
FillRandArr(arrayOne);
if (GetSizeOfSecondArray(arrayOne) == 0){Console.WriteLine("отсутствуют элементы для ввода в новый массив");}
else
{   
    Console.WriteLine($"Матричный массив и дочерний массив, состоящий из 3(менее 3) элементов:");
    Console.WriteLine();
    string[] arrayTwo = RotateElemOfArr(arrayOne);
    Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
    Console.WriteLine();
}
void FillRandArr(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "/.,mnbvcxz\asdfghjkl;'][poiuytrewq`1234567890-=]";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }        
    }
}
int GetSizeOfSecondArray(string[] arr)
{   
    int secondSize = 0;
     for (int i = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] RotateElemOfArr(string[] arr)
{
    string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
