//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Console.WriteLine("Первое число больше. " + Num1 + ">" + Num2 );
Console.Clear();
Console.WriteLine("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());
if (Num1 == Num2 && Num2 == Num3)
{
    Console.WriteLine("Числа равны.");
}
else
{
    if (Num1 > Num2)
    {
        if (Num1 > Num3)
        {
            Console.WriteLine("Первое число больше.");
        }
        else
        {
            if (Num1 == Num3)
            {
                Console.WriteLine("Первое число = Третьему. Второе меньше.");
            }
            else
            {
                Console.WriteLine("Третье число больше.");
            }
        }
    }
    else
    { //Num2 >= Num1
        if (Num2 > Num3)
        {
            if (Num2 == Num1)
            {
                Console.WriteLine("Второе число = Первому. Третье меньше.");
            }
            else
            {
                Console.WriteLine("Второе число больше.");
            }
        }
        else
        {
            if (Num2 == Num3)
            {
                Console.WriteLine("Второе число = Третьему. Первое меньше.");
            }
            else
            {
                Console.WriteLine("Третье число больше..");
            }
        }
    }
}