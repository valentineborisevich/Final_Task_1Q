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

Console.WriteLine("Enter string array's length");
int length = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[length];

FillStringArray(array1);
Console.WriteLine();
Console.Write("Your string array: ");
Console.WriteLine();

PrintStringArray(array1);
Console.WriteLine();
Console.WriteLine("If there are strings with 3 or less characters in it, I'll print them into new array");
Console.WriteLine();

int count = 0;
int j = 0;
int newlength;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3) count++;
}
if (count <= 0)
{
    Console.WriteLine("Array is empty.");
}
else
{
    newlength = count;
    string[] array2 = new string[newlength];

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    Console.Write("Your copied array ");
    Console.WriteLine();
    PrintStringArray(array2);
    Console.WriteLine();
}
