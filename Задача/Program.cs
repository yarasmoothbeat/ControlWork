string[] ChangeStringArray (string[] args)
{
    string[] newStringArray = new string[args.Length];
    for(int i = 0; i < args.Length; i++)
    {
        string str = args[i];
        if (str.Length <= 3)
        {
            newStringArray[i] = str;
        } 
    }
    return newStringArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write( array[i] + " " );
    }
}

string[] strings = new string[4];
strings[0] = "Hello";
strings[1] = "2";
strings[2] = "world";
strings[3] = ":-)";

PrintArray(strings);
Console.WriteLine();
PrintArray(ChangeStringArray(strings));