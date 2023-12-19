string[] array = new string[] {"Hello", "5", "world", "=D", "-!-"};

int len_array = array.Length;

for (int i = 0; i < len_array; i++)
{

    string str_Val = array[i];
    if (str_Val.Length <= 3)
    {
        Console.Write( str_Val + ", ");
    }
}

