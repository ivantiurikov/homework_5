//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// int Check(int[] array)
// {
//     int sum = 0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i] % 2 == 0) sum++;
//     }
//     return sum;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = 100;
// int maxValue = 999;

// int[] array = CreateArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"The amount of even numbers in array is {Check(array)}");



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// int Check(int[] array)
// {
//     int sum = 0;
//     for(int i=1; i<array.Length; i+=2)
//     {
//         sum+=array[i];
//     }
//     return sum;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"The sum of odd elements in array is {Check(array)}");



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// double[] CreateArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = minValue + new Random().NextDouble() * (maxValue-minValue);
//     }
//     return array;
// }

// void ShowArray (double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// double Check(double[] array)
// {
//     double max_elem = array[0];
//     double min_elem = array[0];
//     for(int i=1; i<array.Length; i++)
//     {
//         if(array[i] > max_elem) max_elem = array[i];
//         if(array[i] < min_elem) min_elem = array[i];
//     }
//     return max_elem - min_elem;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[] array = CreateArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"The difference between max and min numbers in array is {Check(array)}");