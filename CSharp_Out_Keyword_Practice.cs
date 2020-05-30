using System;

class Program
{
    static void Main(string[] args)
    {
        //In-line declaring variables without assigning values
        //Passing multiple varaibles to the method using "out" keyword
        Area(out int length, out int width, out int area);

        Console.WriteLine("Length of the rectangle is: " + length);
        Console.WriteLine("Width of the rectangle is: " + width);
        Console.WriteLine("Area of the rectangle is: " + area);
    }

    public static void Area(out int p, out int q, out int area)
    {
        p = 30;
        q = 40;
        area = p * q;
    }
}
