int[] Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    string[] num = line.Split(' ');
    int[] array = new int[num.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(num[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] EvenNumbers(int[] array)
{
    int[] array2 = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array2[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);
    return array2;
}


int [] myarray = Request("Введите натуральные числа через пробел");
PrintArray(myarray);
PrintArray(EvenNumbers(myarray));