int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
        // 0,10: 0,1,2,3,4,5,6,7,8,9
    }
    return array;
}
int [] NewArray (int size)
{
    
    for (int j = array.Length-1; j<array.Length;j++){}
    return array;
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Массив: {NewArray(array)}");

