// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите 3х значное число");
string inputString = Console.ReadLine();
if(inputString.Length != 3)
{
    Console.WriteLine("Неправильное количество символов");
}
else
{
    int Number = int.Parse(inputString);
    Console.WriteLine("Вторая цифра:" + (Number/10)%10);
    //Console.WriteLine("Вторая цифра:" + inputString[1]);
    //формально с числом я так и не поработал. Так что решил сделать оба варианта.
}
