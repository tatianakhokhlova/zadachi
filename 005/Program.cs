// Показать четные числа от 1 до N

Console.WriteLine("Введите число N");
string n = Console.ReadLine();
int N = Convert.ToInt32(n);

int counter = 1;

while(counter <= N)
{
    if(counter % 2 == 0) {
        Console.WriteLine(counter);
    } 
    counter = counter + 1;
}
