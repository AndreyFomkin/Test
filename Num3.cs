Console.Write("Введите двузначное число: ");
int number =Convert.ToInt32(Console.ReadLine());
if (number>=10 && number<=99)
{
    int firstDigit = number/10;
    int secondDigit = number%10;
   int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
   Console.Write("{maxDigit}");
}

