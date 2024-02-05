Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = M;
int end = N;
void ShowNumbers(int start, int end)
{
    if (start == end || start > end || start <0)
{ Console.Write(start); 
      return;
    }
    
    
    Console.Write(start + " "); 
    ShowNumbers(start + 1, end);
}
ShowNumbers(start, N); 

