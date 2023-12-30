Console.Write("Введите  число : ");
int number =Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;
if (number%number1 == 0)
{
    Console.Write($"Число {number} кратно {number1}.");
}
if (number%number2 == 0)
{
    Console.Write($"Число {number} кратно {number2}.");
}
else
{
    Console.Write($"Число {number} не кратно одновременно {number1} и {number2}.");
}