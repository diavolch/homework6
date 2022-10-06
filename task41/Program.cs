/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int getCountOfNumbersGreaterThanNumber(int[] incomingArray, int number)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > number)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите числа через пробелы: ");
int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int number = 10;
int countOfNumbers = getCountOfNumbersGreaterThanNumber(currentArray, number);
Console.WriteLine($"Количество чисел больше {number} = {countOfNumbers}");