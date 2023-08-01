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
