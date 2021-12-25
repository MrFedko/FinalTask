int [] Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    string[] num = line.Split(' ');
    int[] array = new int [num.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(num[i]);
    }
    return array;
}

