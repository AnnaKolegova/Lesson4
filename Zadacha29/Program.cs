void Zadacha29()
{
    Random random=new Random();
    int size=8;
    int []num=new int[size];
    void FillArray(int[]n)
    {
        for (int i=0; i<size; i++)
        {
            n[i]=random.Next(-100,101);
        }
    }
    FillArray(num);
    void PrintArray(int[]n)
    {
        for (int i=0; i<size; i++)
        {
            Console.Write(n[i]+" ");            
        }
        Console.WriteLine();
    }
    PrintArray(num);
    void Sort(int[]n)
    {
        for (int i=0; i<size-1; i++)
        {
            int min=i;
            for (int j=i+1; j<size;j++)
            {
                if (Math.Abs(n[j])<Math.Abs(n[min])) 
                {
                    min=j;
                }
            }
            int temp=n[i];
            n[i]=n[min];
            n[min]=temp;
        }
    }
    Sort(num);
    PrintArray(num);

}
Zadacha29();
