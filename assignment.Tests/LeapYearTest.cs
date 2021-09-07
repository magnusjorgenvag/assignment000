using System;
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
            var actual = IsLeapYear(2364);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIs333_ReturnFalse()
        {
            var expected = false;
            var actual = IsLeapYear(2333);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divisible_By_2_Not_4_Is_Not_Leap()
        {
            var expected = false;
            var actual = IsLeapYear(22);
            Assert.Equal(expected, actual);
        }

        //Check divisable by 100 is not leap
        [Fact]
        public void IsLeap_InputIs300_ReturnFalse()
        {
           var expected = false;
            var actual = IsLeapYear(300);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void IsLeap_InputIs100_ReturnFalse()
        {
            var expected = false;
            var actual = IsLeapYear(100);
            Assert.Equal(expected, actual); 
        } 

        //Chack divisable by 400 is leap

        [Fact]
        public void IsLeap_InputIs400_ReturnTrue()
        {
           var expected = true;
            var actual = IsLeapYear(400);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void IsLeap_InputIs2400_ReturnTrue()
        {
            var expected = true;
            var actual = IsLeapYear(2400);
            Assert.Equal(expected, actual); 
        } 

        public bool IsLeapYear(int year) 
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
