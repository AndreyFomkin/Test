int[] CreateArray(int array)
{
    int[] array = new int[3]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        // 0,10: 0,1,2,3,4,5,6,7,8,9
    }
    return array;
}



for (int i = 0; i < array.Length; i++)
int count=0;
     {
         if (array[i] % 2 == 0)         
         {          
               count++; // count = count + 1
        }
     
     return count;
 }

// // Вызов функции
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
if (N > 3 )
{
    Console.WriteLine("Invalid data");
    return; // Остановится про
}
//  каждый элемент: число от 10 до 99 вкл-но

Console.Write(CreateArray(res));
Console.Write($"Количество элементов массива: .");
