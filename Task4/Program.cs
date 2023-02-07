// Напишите программу, которая принимает 
//на вход число и проверяет, 
//кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

System.Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 7;
int num2 = 23;

int result = num % num1;
int result1 = num % num2;


  if (result == 0 && result1 == 0)
    {
    System.Console.WriteLine($"{num} -> да");
    }
//  альтернативно 
//     if (num % 7 == 0 && num % 23 == 0) 
//     {
//     System.Console.WriteLine($"{num} -> да");
//     }


  else
    {
    System.Console.WriteLine($"{num} -> нет");
    }

    