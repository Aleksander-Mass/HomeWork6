/*
Знакомство с языками программирования (семинары)
Урок 6. Двумерные массивы и рекурсия
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
    Console.Write(arr[i] + ", ");
}
Console.WriteLine($"-> {count}");
*/
/*
Знакомство с языками программирования (семинары)
Урок 6. Двумерные массивы и рекурсия
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/
/*
Console.Write("Введите целое положительное десятичное число: ");
var m = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Число в 10-й системе = {0} ", m));
            string ds = "";
            string tmp = "";
            while (m>0)
            {
                tmp += m & 1;
                m /= 2;
            }
 
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                //Console.Write(tmp[i]);
                ds = ds + tmp[i];
            }
 
            Console.WriteLine();
            Console.WriteLine("Число преобразованное в двоичную систему: " + ds);
*/
/*
Знакомство с языками программирования (семинары)
Урок 6. Двумерные массивы и рекурсия СЕМИНАР
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
k1 = 5, b1 = 2,  k2 = 9, b2 = 4,  -> (-0,5; 5,5)
*/
/*
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение двух прямых в точке: ({x};{y})");
*/