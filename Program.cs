using System;

public class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("\"Input your date of joining\"\nEnter Year in 4-digits:");
        var year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month in 2-digits:");
        var month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter date in 2-digits :");
        var date = Convert.ToInt32(Console.ReadLine());
        DateTime dt = new DateTime(year,month,date);
        Console.Clear();
        Console.WriteLine("Date of Joining:");
        Console.WriteLine(dt);
        Console.WriteLine("Current Date and Time:");
        DateTime today = DateTime.Now;
        Console.WriteLine(today);
        Console.WriteLine("You Spended:"+(today-dt)+"\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b Days                  ");
  
    }
}
