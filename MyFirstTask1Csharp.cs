using System;


/*Employees Data : 
1.  “John, Robert, Chandra, Peter”
2. [“John”, “Robert”, “Chandra”, Peter”]*/

class MyFirstTask1Csharp
/*summary:-1Prepare the String Array,
2.Get the Third Employee from the Array
3.	Check weather Second and Third employee Equals or not from the Array
4.	Check the employee whose name starts with “J” from the Array
5.	Convert Employees List into single String
6.	Replace the “Robert” with “Peter” in String
7.	Get the Employee whose name length is more that 4 charcters from the array*/

{
    static void Main(string[] args)
    {
        /* string[] employees = new string[] { "John", "Robert", "Chandra", "Peter" };
         //bool areEqual = employees[1] == employees[2];
         //Console.WriteLine("Third Employee :" + employees[2]);
        // Console.WriteLine("Second and Third Employee Equal: " + areEqual);
        /* foreach (string emp in employees)
         {
             if (emp.StartsWith("J"))
                 Console.WriteLine("Employee name starts with J: " + emp);
         }
         string employeeString = string.Join(", ", employees);
         Console.WriteLine("Employees: " + employeeString);
         string replaced = employeeString.Replace("Robert", "Peter");
         Console.WriteLine("After Replace: " + replaced);
         foreach (string emp in employees)
         {
             if (emp.Length > 4)
                 Console.WriteLine("Name > 4 characters: " + emp);
         }



        //9.Dif Btw For and For Loop Along with Example
        /*for                                               foreach

        it can access Index                            no Direct Access to Index
        in this syntax is Complex                      in this Syntax is cleaner and Faster*/

        //for loop
        /*


             string[] employees = { "John", "Robert", "Chandra", "Peter" };

             for (int i = 0; i < employees.Length; i++)
             {
                 Console.WriteLine(employees[i]);
             }*/





        //Foreach

        string[] employees = { "John", "Robert", "Chandra", "Peter" };

        foreach (string emp in employees)
        {
            Console.WriteLine("Employee: " + emp);
        }


        // 9.Importance of looping System with Example  

        //looping helps in Repeating Tasks without writng code multiple times

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Repeat " + i);
        }

        // 10.What are the Floating DataTypes.Example

        //Float
        // Double
        //Decimal

        float f = 1.23f;
        double d = 12.3456;
        decimal m = 123.456789m;

        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(m);

        //11.What are the Logical Operators Importance of that? with Example.

        /* && (AND)

         ||(OR)

         ! (NOT)*/


        bool a = true, b = false;

        if (a && b)
            Console.WriteLine("Both true");
        else if (a || b)
            Console.WriteLine("At least one is true");
        else
            Console.WriteLine("None of the Above is True");

        //12.What is the Nullable Types?With Example
        /*1. A nullable type allows a value type like int, bool, double, etc. to hold an additional value
          2. Nullable types allow you to assign null to value types.*/

        int? age = null;
        if (age.HasValue)
            Console.WriteLine("Age is: " + age);
        else
            Console.WriteLine("Age is not Given.");
        //13.What is Implicit Conversion Type.With Example
        int x = 100;
        double y = x; //Implicit Conversion
        Console.WriteLine(y);
    }
}






  
















