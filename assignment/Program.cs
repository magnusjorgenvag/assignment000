using System;

namespace assignment
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           Console.WriteLine("Enter Year:");
           int year = Convert.ToInt32(Console.ReadLine());
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
