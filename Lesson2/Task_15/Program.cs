// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int dayOfWeek = int.Parse(Console.ReadLine());
if (dayOfWeek<8 && dayOfWeek>0)
{
    if(dayOfWeek==6 || dayOfWeek==7)
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Будний((");
    }
}
else
{
    Console.WriteLine("Число выходит за диапазон [1;7]");
}