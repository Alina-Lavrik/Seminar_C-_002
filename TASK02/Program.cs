/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4  -> кратно */

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int Remain = number1 % number2;

if(Remain == 0) 
{
    Console.WriteLine($"{number1} кратно {number2}");
}
else {
    Console.WriteLine($"{number1} не кратно {number2}, остаток {Remain}");
}
