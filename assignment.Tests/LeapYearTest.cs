using System;
using System.IO;
using Xunit;

namespace assignment.Tests
{
    public class LeapYearTest
    {

//Check if divisable by 4 is leap
        [Fact]
        public void IsLeap_InputIs2364_ReturnTrue() 
        {
            var expected = true;
            var actual = Program.IsLeapYear(2364);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIs333_ReturnFalse()
        {
            var expected = false;
            var actual = Program.IsLeapYear(2333);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divisible_By_2_Not_4_Is_Not_Leap()
        {
            var expected = false;
            var actual = Program.IsLeapYear(22);
            Assert.Equal(expected, actual);
        }

        //Check divisable by 100 is not leap
        [Fact]
        public void IsLeap_InputIs300_ReturnFalse()
        {
           var expected = false;
            var actual = Program.IsLeapYear(300);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void IsLeap_InputIs100_ReturnFalse()
        {
            var expected = false;
            var actual = Program.IsLeapYear(100);
            Assert.Equal(expected, actual); 
        } 

        //Chack divisable by 400 is leap

        [Fact]
        public void IsLeap_InputIs400_ReturnTrue()
        {
           var expected = true;
            var actual = Program.IsLeapYear(400);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void IsLeap_InputIs2400_ReturnTrue()
        {
            var expected = true;
            var actual = Program.IsLeapYear(2400);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void LeapTrue_Prints_Yay()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("24");
            Console.SetIn(input);
            Program.Main(new string[] {});

            var actual = writer.GetStringBuilder().ToString();
            Assert.Equal("Enter Year:\r\nyay\r\n", actual);
            //Assert.That("yay", Is.EqualTo(string.Format("What's your name?{0}Hello Somebody!!{0}", Environment.NewLine))); 
        }

        [Fact]
        public void LeapFalse_Prints_Nay()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("333");
            Console.SetIn(input);
            Program.Main(new string[] {});

            var actual = writer.GetStringBuilder().ToString();
            Assert.Equal("Enter Year:\r\nnay\r\n", actual);
        }

        /*public bool IsLeapYear(int year) 
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
        } */
    }
}
