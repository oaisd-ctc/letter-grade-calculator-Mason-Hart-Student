using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your current percentage? (0-100)");
        double percent = double.Parse(Console.ReadLine());

        if (percent >=0) {
            if (percent < 60) {
            Console.WriteLine("Don't Give up!");
            Console.WriteLine("Letter grade: E");
            }
        }
        if (percent >= 60) {
            if (percent < 70) {
            Console.WriteLine("Keep trying!");
            Console.WriteLine("Letter grade: D");
            }
        }
        if (percent >= 70) {
            if (percent < 80) {
            Console.WriteLine("You got this, keep working!");
            Console.WriteLine("Letter grade: C");
            }
        }
        if (percent >= 80) {
            if (percent < 90) {
            Console.WriteLine("Keep it up!");
            Console.WriteLine("Letter grade: B");
            }
        }
        if (percent >= 90) {
            if (percent < 100) {
            Console.WriteLine("Very nice!!");
            Console.WriteLine("Letter grade: A");
            }
        }
        if (percent >=100) {
            Console.WriteLine("Wow! 100... That's impressive!");
            Console.WriteLine("Letter grade: A+");
        }
    }
}