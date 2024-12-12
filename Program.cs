

using System;
#region Q1
class Q1
{
    static void Main()
    {

        int number = 5;
        Console.WriteLine(number);
    }
}
#endregion
#region Q2

class Q2
{
    static void Main()
    {
        int x = 10;
        int y = x; 
        y = 20;    

        Console.WriteLine(x); // Output: 10
        Console.WriteLine(y); // Output: 20
    }
}
// When assigning one value type to another, a copy of the value is made. Changes to one variable do not affect the other
#endregion
#region Q3

class Q3
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = str1; 
        str2 = "World";     

        Console.WriteLine( str1);
        Console.WriteLine( str2); 
    }
}

#endregion

