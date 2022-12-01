
int[] numbers = new int[3];

Console.WriteLine("Введите первое число: ");
numbers[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
numbers[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
numbers[2] = int.Parse(Console.ReadLine());

int max = numbers[0];
int i = 1;

while (i < 3)
{
    if(numbers[i] > max)
        max = numbers[i];
    i = i + 1;   
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);