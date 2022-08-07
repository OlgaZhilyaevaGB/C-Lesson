Console.WriteLine("Введите первое число: ");
int number1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2=int.Parse(Console.ReadLine());

if (number1>number2)
{
    Console.WriteLine($"Первое число {number1} больше второго {number2}");
    
}
else if (number1<number2) 
     {
     Console.WriteLine($"Второе число {number2} больше первого {number1}");
    }
else
{
 Console.WriteLine("Числа равны");
}
