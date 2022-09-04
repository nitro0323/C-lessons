//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear();
Console.WriteLine("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
if(Num1>Num2){
    Console.WriteLine("Первое число больше. " + Num1 + ">" + Num2 );
}
else if(Num2>Num1){
    Console.WriteLine("Второе число больше. " + Num2 + ">" + Num1 );
}
else{
    Console.WriteLine("Числа равны");
}