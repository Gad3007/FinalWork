string[] array = new string[] {"Hello", "5", "world", "=D", "-!-"};

int len_array = array.Length;
Console.WriteLine();
Console.Write("New Array - [");

for (int i = 0; i < len_array; i++)
{

    string str_Val = array[i];
    if (str_Val.Length <= 3)
    {
        Console.Write( str_Val + ", ");
    }
}
Console.Write("]");
