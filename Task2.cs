
    while (true)
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();
         if (text=="q")
         {
        
            break;
            }
            int number;
            if(int.TryParse(text,out number));
            {
                Console.WriteLine("Введенная строка состоит из цифр.");
              
    int sum = 0;
   
    while(number>0)
    {
 int firstDigit = number/10;
    int twoDigit = number%10;
        sum = firstDigit + twoDigit;
    }
    if ( sum % 2 == 0)
    {
        break;
    }
}
}
  