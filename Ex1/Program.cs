/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
Console.Write("Введите количество чисел ");
int elCount = int.Parse(Console.ReadLine());
int count = 0;
int[] mass = new int[elCount];
for (int i = 0; i < elCount; i++)
{
    Console.Write($"Введите число {i + 1}, осталось ввести {elCount - i} ");
    mass[i] = int.Parse(Console.ReadLine());
    if (mass[i] > 0) count++;
}
System.Console.WriteLine($"Чисел больше 0 - {count}");





