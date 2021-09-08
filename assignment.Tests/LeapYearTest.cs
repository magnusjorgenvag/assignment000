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
            var actual = Program.IsLeapYear(2222);
            Assert.Equal(expected, actual);
        }

        //Check divisable by 100 is not leap
        [Fact]
        public void IsLeap_InputIs300_ReturnFalse()
        {
           var expected = false;
            var actual = Program.IsLeapYear(2300);
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void IsLeap_InputIs100_ReturnFalse()
        {
            var expected = false;
            var actual = Program.IsLeapYear(2100);
            Assert.Equal(expected, actual); 
        } 

        //Chack divisable by 400 is leap


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

            var input = new StringReader("2024");
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

            var input = new StringReader("3333");
            Console.SetIn(input);
            Program.Main(new string[] {});

            var actual = writer.GetStringBuilder().ToString();
            Assert.Equal("Enter Year:\r\nnay\r\n", actual);
        }

        [Fact]
        public void Below1582_ThrowsException()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Program.IsLeapYear(1333));
            Assert.Equal("The asserted year is below 1582", ex.Message);
        }

        [Fact]
        public void InputLetter_ThrowsException()
        {
            var input = new StringReader("Totusenogfjorten");
            Console.SetIn(input);
            
            var ex = Assert.Throws<FormatException>(() => Program.Main(new string[] {}));
            Assert.Equal("Input string was not in a correct format.", ex.Message);
        }

        [Fact]
        public void InputDouble_ThrowsException()
        {
            var input = new StringReader("2431.423");
            Console.SetIn(input);
            
            var ex = Assert.Throws<FormatException>(() => Program.Main(new string[] {}));
            Assert.Equal("Input string was not in a correct format.", ex.Message);
        }
    }
}
