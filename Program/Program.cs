
static string[] SelectArray(string[] inputStringArray)
{
      string[] newStringArray = new string[inputStringArray.Length];

    for (int i = 0; i < inputStringArray.Length; i++)
    {
        if (inputStringArray[i].Length <= 3)
        {
            newStringArray[i] = inputStringArray[i];
        }
    }
    newStringArray = newStringArray.Where(x => x != null).ToArray();

    return newStringArray;
}

static void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write(@"[""" + array[i] + @""", ");
        else if (i == array.Length - 1) Console.Write(@"""" + array[i] + @"""]");
        else Console.Write(@"""" + array[i] + @""", ");
    }
}

Console.WriteLine("Введите элементы строкового массива через запятую:");
string? taskString = Console.ReadLine();
string[] stringArray = taskString!.Split(",", StringSplitOptions.RemoveEmptyEntries);

WriteArray(array: stringArray);
Console.Write(" -> ");
WriteArray(array: SelectArray(inputStringArray: stringArray));
