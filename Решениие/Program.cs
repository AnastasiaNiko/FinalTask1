 string[] lenghtArray = { "hello", "day", "04", "sept", "2023", ":-)" };

    string[] array1 = new string[lenghtArray];

    int maxLength = 3;

    void CutArray(string[] array, string[] array1)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                array1[count] = array[i];
                count++;
            }
        }
    }
    void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]} ");
        }
        Console.WriteLine();
    }
    CutArray(lenghtArray, array1);
    Console.Write( $"Введен  массив: {lenghtArray}");
    PrintArray(lenghtArray);
    Console.Write($"Элементы массива <= 3 символам: ");
    PrintArray(array1);



