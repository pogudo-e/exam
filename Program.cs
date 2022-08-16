string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer sciense"};


int HowElem(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] NewArray(string[] array)
{
    string[] newarray = new string[HowElem(array)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

Console.WriteLine($"[{String.Join(", ",NewArray(array))}]");
Console.WriteLine($"[{String.Join(", ",NewArray(array2))}]");
