// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArray(int len)
// {
//     int[] myArray = new int[len];
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(100, 1000);
//     }
//     return myArray;
// }


// void PrintArray(int[] array)
// {
//     foreach (int i in array) Console.Write($"{i}  ");
// }

// void EvenNumbers(int[] array)
// {
//     int evenCount = 0;
//     foreach (var item in array)
//     {
//         evenCount += item % 2 == 0 ? 1 : 0;
//     }
//     Console.WriteLine($"Kоличество чётных чисел в массиве: {evenCount}");

// }

// Console.Write("Введите длину массива: ");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(len);
// Console.WriteLine("Заданный массив:");
// PrintArray(myArray);
// Console.WriteLine();
// EvenNumbers(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int len)
// {
//     int[] myArray = new int[len];
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(-10, 10);
//     }
//     return myArray;
// }


// void PrintArray(int[] array)
// {
//     foreach (int i in array) Console.Write($"{i}  ");
// }

// void SumEvenIndex(int[] array)
// {
//     int sumEven = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sumEven = array[i] + sumEven;
//     }
//     Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {sumEven}");
// }

// Console.Write("Введите длину массива: ");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(len);
// Console.WriteLine("Заданный массив:");
// PrintArray(myArray);
// Console.WriteLine();
// SumEvenIndex(myArray);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//  Так как вещественные числа -- числа, которые обладают дробной частью.
// И Они могут быть как положительными, так и отрицательными.
// То массив задаем как double 

// double[] CreateArray(int len)
// {
//     double[] myArray = new double[len];
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(-10, 10);
//     }
//     return myArray;
// }


// void PrintArray(double[] array)
// {
//     foreach (int i in array) Console.Write($"{i}  ");
// }


// void Result(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     Console.WriteLine("Разницa между максимальным и минимальным элементов массива:");
//     Console.WriteLine($"{max} - {min} = {max - min}");

// }


// Console.Write("Введите длину массива: ");
// int len = Convert.ToInt32(Console.ReadLine());
// double[] myArray = CreateArray(len);
// Console.WriteLine("Заданный массив:");
// PrintArray(myArray);
// Console.WriteLine();
// Result(myArray);