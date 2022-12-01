// /*
// Здесь я буду сохранять все дз, которые мы делали в течение курса с Сергеем
// Это на будущее, чтобы было чуть проще в дальнейшем
// */

// /* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
// */
// Console.Write( "Введите первое число  ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write( "Введите второе число  ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA < numberB)
// {
//     Console.WriteLine("Большим числом является : " + numberB);
//     Console.WriteLine("Меньшим числом является : " + numberA);
// }
//  else
//  {
//     Console.WriteLine("Большим числом является : " + numberA);
//     Console.WriteLine("Меньшим числом является : " + numberB);
//  }

//  /*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// */

// Console.Write( "Введите первое число  ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write( "Введите второе число  ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.Write( "Введите третье число  ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// if (numberA > numberB && numberA > numberC)
// {
//     Console.WriteLine("Максимальным числом является : " + numberA);
// }

// if (numberB > numberC && numberB > numberA)
// {
//     Console.WriteLine("Максимальным числом является : " + numberB);
// }

// if (numberC > numberA && numberC > numberB)
// {
//     Console.WriteLine("Максимальным числом является : " + numberC);
// }

// /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// */

// Console.Write("Введите число ");
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
// int number2 = 2;
//     if (number % number2 == 0)
// {
//     Console.WriteLine("Число является четным : " + number);
// }
//     else
// {
//     Console.WriteLine("Число является нечетным : " + number);
// }

// /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// */

// Console.Write("Введите число ");
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
// int number2 = 2;
//     if (number % number2 == 0)
// {
//     Console.WriteLine("Число является четным : " + number);
// }
//     else
// {
//     Console.WriteLine("Число является нечетным : " + number);
// }

// /*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 
// */

// Console.Write( "Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int M = 1;
// while  (M <= N)
// {
//     if (M % 2 == 0)
//     Console.WriteLine("Четные числа : " + M);
//     M = M + 1;
// }

// /*Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// */

// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("Второй цифрой введенного числа является : "+stringNumber[1]);

// /*Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// */

// Console.Write("Введите любое число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("Третьей цифрой введенного числа является : " + anyNumberText[2]);
// }
// else 
// {
//   Console.WriteLine("У числа " + anyNumberText + " нет третьей цифры!");
// }

// /*Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// */

// Console.Write("Введите цифру, обозначающую день недели: ");
// int NumberOfTheDay = Convert.ToInt32(Console.ReadLine());

// void CheckDayOfTheWeek (int NumberOfTheDay) 
// {
//   if (NumberOfTheDay == 6 || NumberOfTheDay == 7) 
//   {
//   Console.WriteLine("Выходной");
//   }
//   else 
//   if (NumberOfTheDay < 1 || NumberOfTheDay > 7) 
//   {
//     Console.WriteLine("Такого номера дня недели нет");
//   }
//   else 
//   Console.WriteLine("Не выходной");
// }

// CheckDayOfTheWeek(NumberOfTheDay);

/*_____________________________________________________________*/

/*int[] Solution(int[] collectionElements, int evenCounts)
{
  int[] items = new int[evenCounts];
  int length = collectionElements.Length;
  int position = 0;
  int indexInItems = 0;
  while (position < length)
  {
    if (collectionElements[position] % 2 == 0)
    {
      items[indexInItems] = collectionElements[position];
      indexInItems++;
    }
    position++;
  }
  return items;
}
*/


// /*Напишите метод, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Все комментарии я оставляю для себя на будущее, 
// чтобы не потеряться и ничего не забыть
// */

// Console.WriteLine("Введите первое число А: ");  //число, которое нужно возвести в степень
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Веедите число В: ");         //степень числа
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;                                 //число, возведенное в степень

// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine( a + " ^ " + b + " = " + step);


// /*Напишите метод, 
// который принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// */

// Console.WriteLine("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("Сумма всех цифр в числе = " + sum);


// /*Задача 29: Напишите методы, 
// который задаёт массив из 8 элементов 
// и выводит их на экран.*/

// using static Library;
// int[] col = CreateArray(8);
// Console.WriteLine(PrintGood(col));
// Console.WriteLine();
// Fill(col, 1, 20);
// Console.WriteLine(PrintGood(col));


