Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;

    if(max < b)
    {
        max = b;
    }
    else
    {
        if(max < c)
        {
          max = c;  
        }
    }
Console.Write("Максимальное число:  ");
Console.WriteLine(max);