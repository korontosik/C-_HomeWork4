// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Clear();

// while (true)
// {
//     Console.Write("Enter number or 'q' to exit: ");
//     string input = Console.ReadLine();
//     int sum = 0;
//     int num = 0;

//     if (input == "q")
//     {
//         Console.WriteLine("End");
//         break;
//     }
//     int.TryParse(input, out num);
//     while (num > 0)
//     {
//     sum = sum + num % 10;
//     num = num / 10;
//     }
//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("End");
//         break;
//     }
// }


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] Array = {1,3,5,6,8,4};


// int[] Array (int arraySize) // Функция создания массива с случайными числами от 100 до 999
// {
//     int[] randomArray = new int [arraySize];
//     for (int i = 0; i < arraySize; i++)
//     {
//         randomArray[i] = new Random().Next(100, 1000);
//     }
//     return randomArray;
// }


// int CountEvenNumbers (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         count ++;    
//     }
//     return count;
// }



// void ShowArray (int [] arrayToShow)
// {
//     foreach (int val in arrayToShow)
//     {
//         Console.Write($"{val} ");
//     }
// }

// // int size = 10;
// int[] arrayTask1 = Array(5);
// ShowArray(arrayTask1);
// Console.WriteLine();
// Console.WriteLine("Event numbers: " + CountEvenNumbers(arrayTask1));

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = {1, 3, 5, 6, 7, 8};
int[] array2 = new int[array.Length];

for (int i = array.Length - 1; i >= 0; i--)
{
    array2 = array;
    Console.Write($"{array2[i]} ");
}


