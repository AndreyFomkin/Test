Console.Write("Введите координаты оси x: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты оси y: ");
int y =Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.Write($"Вы ввели неверные координаты.");
}
if (x> 0 && y> 0)
{
    Console.Write($"Первая координатная четверть.");
}
if (x < 0 && y > 0)
{
    Console.Write($"Вторая координатная четверть.");
}
if (x<0 && y<0)
{
    Console.Write($"Третья координатная четверть."); 
}
if (x>0 && y<0)
{
    Console.Write($"Четвёртая координатная четверть."); 
}