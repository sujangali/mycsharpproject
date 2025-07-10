using System;
class MyFirstTask2Csharp
{
    //Prepare the Method with params with return types.
    public static int CalculateSum(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    static void Main()
    {
        // Example usage
        int result1 = CalculateSum(10, 20, 30);
        int result2 = CalculateSum(5, 15);

        Console.WriteLine("Sum 1: " + result1);  // Output: Sum 1: 60
        Console.WriteLine("Sum 2: " + result2);  // Output: Sum 2: 20
    }
    //Prepare the Methods with conditions(if elseif else)
    void CheckGrade(int marks)
    {
        if (marks >= 90)
            Console.WriteLine("Grade A");
        else if (marks >= 75)
            Console.WriteLine("Grade B");
        else
            Console.WriteLine("Grade C");
    }

    //Prepare the methods with Conditions(switch case)
    void DayOfWeek(int day)
    {
        switch (day)
        {
            case 1: Console.WriteLine("Monday");
                break;
            case 2: Console.WriteLine("Tuesday"); 
                break;
            default: Console.WriteLine("Other Day");
                break;
        }
    }

    //Prepare the Methods with if else if else and Switch case conditions.

    void CheckStatus(int code)
    {
        if (code >= 1 && code <= 5)
        {
            switch (code)
            {
                case 1: Console.WriteLine("Pending"); break;
                case 2: Console.WriteLine("Approved"); break;
                case 3: Console.WriteLine("Rejected"); break;
                default: Console.WriteLine("Unknown"); break;
            }
        }
        else
        {
            Console.WriteLine("Invalid Code");
        }
    }

}

