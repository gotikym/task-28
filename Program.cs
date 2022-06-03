using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        int userInput;
        int temporaryItem;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }

        Console.WriteLine("\nНа сколько элементов сдвинуть массив?");
        userInput = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < userInput; i++)
        {
            temporaryItem = array[0];

            for (int j = 0; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }

            array[array.Length - 1] = temporaryItem;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
}