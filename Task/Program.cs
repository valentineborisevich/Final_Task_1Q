void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter string");
        array[i] = Console.ReadLine();
    }
}

string[] PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Console.Write("["+array[i] + "] ");
        Console.Write($"'{array[i]}' ");
    }
    return array;
}