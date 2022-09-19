/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int num1 = number / 100;
int num2 = number % 10;

int result = num1*10 + num2;
Console.WriteLine(result);
