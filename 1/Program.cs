
Console.WriteLine("Введите первое число:");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (namber1 > number2)

{
    Console.WriteLine("Первое число больше второго");
}

else if (namber1 < number2)

{
    Console.WriteLine("Второе число больше первого");
}

else 
{
    Console.WriteLine("Числа равны");
} 
