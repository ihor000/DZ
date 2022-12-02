
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2; 

while (number > i)
{
    Console.WriteLine(i);
    i += 2;    
}