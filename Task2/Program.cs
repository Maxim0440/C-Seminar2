//Напишите программу, которая выводит 
//случайное трехзначное число и удаляет 
//вторую цифру этого числа. "'это от 100 -1000
// так как 1000 не будет включаться

//456 -> 46
//782 -> 72
//918 -> 98
int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int firstNum = num / 100;
int secondNum = num % 10;
int result = firstNum * 10 + secondNum;
System.Console.WriteLine(result);

// или так int result = (num / 100) * 10 + num % 10;
// System.Console.WriteLine($"{num} -> {result}");