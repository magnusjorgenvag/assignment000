using System;

namespace assignment
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Enter Year:");
           string stringyear = Console.ReadLine();
           int year = Convert.ToInt32(stringyear);
           bool isLeap = IsLeapYear(year);
           
           if(isLeap) 
           {
                Console.WriteLine("yay"); 
           } else 
           {
               Console.WriteLine("nay");
           }
        }
        public static bool IsLeapYear(int year) 
        {
            if(year < 1582) 
            {
                throw new InvalidOperationException("The asserted year is below 1582");
            }
            
            if (year % 4 == 0) 
            {
                if (year % 100 == 0) 
                {
                    if(year % 400 == 0) 
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            } else
            {
                return false;
            }
        }
        
    }
}
