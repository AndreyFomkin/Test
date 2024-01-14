void PrintSquares (int Limit)
{
    int i= 1;
    while (i<=Limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSquares(8);