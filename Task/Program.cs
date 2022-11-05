string[] GetString()
{
    Console.WriteLine("Введите значения через запятую без пробелов : ");
    return Console.ReadLine().Split(",");
}

int GetLength(string[] arr, int n)
{
    int len = 0;
    for (int m = 0; m < arr.Length; m++)
    {
        if (arr[m].Length <= n)
            len++;
    }
    return len;
}

string[] FindLess(string[] inputMassiv, int n)
{
    string[] result = new string[GetLength(inputMassiv, n)];
    for (int i = 0, j = 0; i < inputMassiv.Length; i++)
    {
        if (inputMassiv[i].Length <= n)
        {
            result[j] = inputMassiv[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output = FindLess(input, 3);

Console.WriteLine($"{string.Join(", ", input)} -> {string.Join(", ", output)}");
