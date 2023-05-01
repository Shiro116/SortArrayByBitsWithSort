int[] integers = { 7, 6, 14, 2, 6 };
/*
 * 7 - 0111 = 3bits
 * 6 - 0110 = 2bits
 * 14 - 1110 = 3bits
 * 2 - 0010 = 1bits
 */
Array.Sort(integers, SortByBits);

foreach (int i  in integers)
{
    Console.WriteLine(i);
}

int SortByBits (int x, int y)
{
    string xStr = Convert.ToString(x, 2);
    string yStr = Convert.ToString(y, 2);

    int xBits = 0;
    int yBits = 0;

    for (int i = 0; i < xStr.Length || i < yStr.Length;  i++)
    {
        if (i < xStr.Length && i < yStr.Length)
        {
            if (xStr[i] == '1')
                xBits++;
            if (yStr[i] == '1')
                yBits++;
        }
        else if (i < xStr.Length)
        {
            if (xStr[i] == '1')
                xBits++;
        }
        else
        {
            if (yStr[i] == '1')
                yBits++;
        }
    }

    if (xBits > yBits)
        return 1;
    else if (yBits > xBits) 
        return -1;
    else
    {
        return x.CompareTo(y);
    }
}
