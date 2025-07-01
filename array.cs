using System;
class array
{
    static void Main()
    {
        int[] numbers = new int[5];
        numbers[0] = 15;
        numbers[1] = 30;
        numbers[2] = 50;
        numbers[3] = 60;
        numbers[4] = 100;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
