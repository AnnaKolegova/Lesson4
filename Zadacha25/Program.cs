void Zadacha25()
{
    Console.WriteLine("Введите число");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    int b=Convert.ToInt32(Console.ReadLine());
    int pow=1;
    for (int i=0; i<b; i++)
    {
        pow=pow*a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {pow}");

}
Zadacha25();
