//По двум заданным числам проверять является ли первое квадратом второго

int A = new Random().Next(1, 50);
int B = new Random().Next(1, 10);
if (B*B==A)
Console.WriteLine($"Число {A} квадрат числа {B}");
else Console.WriteLine($"Число {A} не квадрат числа {B}");

Console.WriteLine();
