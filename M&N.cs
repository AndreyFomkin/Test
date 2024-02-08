 1 Задача

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = M;
/int end = N;
void ShowNumbers(int start, int end)
{
   if (start == end || start > end)
{ Console.Write(start); 
     return;
  }
   Console.Write(start + " "); 
   ShowNumbers(start + 1, end);
}
ShowNumbers(start, N); 

2 Задача



Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int A (int m, int n)
{ 
    
    if (n == 0) {
        return m + 1;
        }
        

if (n != 0 && m == 0) {
    return A(n - 1, 1);
    }
    
if (n > 0 && m > 0) {
    return A(n - 1, A(n, m - 1));
    }



}
void A (int m, int n)
{
    int res = A (m,n);

    Console.WriteLine ($"{res}");
}


    3 Задача

int [] array = {6,2,9,7,5,8};
int size = array.Length;
int ShowArray (int [] array, int size)
{   
    if (size == 0)
    {
        Console.WriteLine (array );
        return size;
    }
return size;
    
}
ShowArray (array, size);
Console.WriteLine (size-1);




