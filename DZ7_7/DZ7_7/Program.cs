using DZ7_7;
using System;
ArrayWorker worker = new ArrayWorker();

Console.Clear();
Console.WriteLine("     Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк," +
    "\r\n длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры," +
    "\r\n либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями," +
    "\r\n лучше обойтись исключительно массивами." +
    "\r\n   Примеры:\r\n" +
    "   [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]\r\n\r\n" +
    "   [“1234”, “1567”, “-2”, “computer science”] → [“-2”]\r\n\r\n" +
    "   [“Russia”, “Denmark”, “Kazan”] → []");
Console.WriteLine();

string[] Array = new string[] { };
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());

Array = new string[n];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($" Введите симиволы {i + 1}-ого элемента: ");
    Array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Введённый массив:");
Console.WriteLine($"{worker.PrintArray(Array)}");
Console.WriteLine();

int length = 3;
int numbers = worker.CheckArray(Array, length);// переменная с элементом массива, меньше либо равного 3 символам 

string[] newArray = new string[numbers]; // создаем новый  с количеством, равным количеству коротких элементов
worker.NewArray(Array, newArray, length);

Console.WriteLine("Строки массива,  длина которых меньше, либо равна 3 символам:");
Console.WriteLine($"{worker.PrintArray(newArray)}");