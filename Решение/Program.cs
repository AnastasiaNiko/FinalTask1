string [] array = new string [] {"hello", "day", "04", "sept", "2023", ":-)"};
string [] array1 = new string [array.Length];
array1Result(array, array1);

Console.Write("Введен массив:  ");


void array1Result (string [] array, string [] array1)
{
    int count = 0;
    for ( int i = 0; i < array.Length; i ++)
    {
        if (array [i].Length <= 3)
        {
            array1 [count] = array [i];
            count ++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write ($"{array [i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);
Console.Write("Элименты массива <= 3: ");
PrintArray(array1);

