//задача 31
// задается массив от -9 до 9 найти сумму положительных и отрицательных чисел
// int size = 12;
// int[] array = new int[size];
// int sumpositive = 0;
// int sumnegative = 0;

// for(int i = 0; i < size; i++)// array.Lenght = size  ТОЖ САМОЕ
// {
//     array[i] = new Random().Next(-9 , 10);
//     if(array[i]>0)
//     {
//         sumpositive += array[i];
//     }
//     else
//     {
//         sumnegative += array[i];
//     }
// }
// Console.WriteLine($"{string.Join("; ", array)}");
// Console.WriteLine($"Сумма положительных элементов равна {sumpositive}");
// Console.WriteLine($"Сумма отрицательных элементов равна {sumnegative}");



// int[] getarray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max +1); 
//     }
//     return result;
// }
// int[] reverse(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// int[] array = getarray(7, 0, 10);
// Console.WriteLine($"{string.Join("; ", array)}");
// reverse(array);
// Console.WriteLine($"{string.Join("; ", array)}");


// написать программму которая ище в массиве определенное число

// int[] getarray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max +1); 
//     }
//     return result;
// }


// bool Findelement(int[] arr, int element)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == element)
//         {
//             return true;
//         }
//     } 
//     return false;   
// }
// int[] array = getarray(7, 0, 10);

// Console.WriteLine($"{string.Join("; ", array)}");


// int numforsearch = 10;
// if(Findelement(array, numforsearch))
// {
//     Console.WriteLine($"Элемент {numforsearch} присутвует ");
// }
// else
// {
//     Console.WriteLine($"Элемент {numforsearch} отсутсвует ");
// }


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] getarray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1); 
    }
    return result;
}
int[] array = getarray(7, 100, 1000);

        int a = 0;
        for(int i = 0; i < array.Length; i++)
        {
           if(array[i] % 2 == 0)
            {
             a++;
            }
        }  
    Console.WriteLine($"{string.Join("; ", array)}");
    Console.WriteLine($"Количество четных элементов {a}");
// К сожалению времени хватило только на эту задачу. Далее буду решать для себя, получается уже без проверки
// и буду разбираться почему не работает метод poisk который хотел внедрить, не могу вернуть переменную "a"
// удалил метод, что бы код работал напрямую так сказать.