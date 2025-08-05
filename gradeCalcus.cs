using System;

class Program
{
    static void Main()
    {
        // User to enter a numerical grade
        Console.Write("Enter your numerical grade (0-100): ");
        int grade = Convert.ToInt32(Console.ReadLine());

        // Grade Calculator
        if (grade >= 90)
        {
            Console.WriteLine("A - Excellent job hommie!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B - Good job!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C - Fair effort, but you can do better!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D - By the horse's hair. Needs improvement!");
        }
        else
        {
            Console.WriteLine("F - thats crazy dawg! its aight, just try harder next time!");
        }
    }
}
