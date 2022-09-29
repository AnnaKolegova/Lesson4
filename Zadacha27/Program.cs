void Zadacha27()
{
    Console.WriteLine("Введите число");
    int a=Convert.ToInt32(Console.ReadLine());
    int b=a;
    int sum=0;
    while (a>0)
    {
        sum=sum+a%10;
        a=a/10;

    }
    Console.WriteLine($"Сумма цифр числа {b} равна {sum}");
    
}
Zadacha27();
