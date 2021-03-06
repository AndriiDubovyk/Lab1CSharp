using Lab1CSharp.Models;
using System;
using Xunit;

namespace Analyser.Tests
{
    public class BirthdateTest
    {
        [Fact]
        public void GetAgeTest()
        {
            //Arrange
            var todayDate = new DateTime(2022, 02, 10);
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 08, 01), todayDate);
            var ba2 = new BirthdateAnalyser(new DateTime(2000, 02, 10), todayDate);
            var ba3 = new BirthdateAnalyser(new DateTime(2000, 02, 11), todayDate);

            var expected1 = 18;
            var expected2 = 22;
            var expected3 = 21;

            //Act
            var actual1 = ba1.GetAge();
            var actual2 = ba2.GetAge();
            var actual3 = ba3.GetAge();

            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void GetChineseZodiacSignTest()
        {
            //Arrange
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 05, 05));
            var ba2 = new BirthdateAnalyser(new DateTime(1992, 01, 01));
            var ba3 = new BirthdateAnalyser(new DateTime(2000, 02, 11));

            var expected1 = "Goat";
            var expected2 = "Monkey";
            var expected3 = "Dragon";

            //Act
            var actual1 = ba1.GetChineseZodiacSign();
            var actual2 = ba2.GetChineseZodiacSign();
            var actual3 = ba3.GetChineseZodiacSign();

            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void GetWesternZodiacSignTest()
        {
            //Arrange
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 08, 01));
            var ba2 = new BirthdateAnalyser(new DateTime(1992, 12, 22));
            var ba3 = new BirthdateAnalyser(new DateTime(2000, 01, 01));
            var ba4 = new BirthdateAnalyser(new DateTime(2000, 09, 28));

            var expected1 = "Leo";
            var expected2 = "Capricorn";
            var expected3 = "Capricorn";
            var expected4 = "Libra";

            //Act
            var actual1 = ba1.GetWesternZodiacSign();
            var actual2 = ba2.GetWesternZodiacSign();
            var actual3 = ba3.GetWesternZodiacSign();
            var actual4 = ba4.GetWesternZodiacSign();

            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }

        [Fact]
        public void BirthdayIsTodayTest()
        {
            //Arrange
            var todayDate = new DateTime(2022, 08, 01);
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 08, 01), todayDate);
            var ba2 = new BirthdateAnalyser(new DateTime(1992, 12, 22), todayDate);


            //Act
            var actual1 = ba1.BirthdayIsToday();
            var actual2 = ba2.BirthdayIsToday();

            //Assert
            Assert.True(actual1);
            Assert.False(actual2);
        }

        [Fact]
        public void ValidateBirthdateTest()
        {
            //Arrange
            var todayDate = new DateTime(2021, 02, 11);
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 08, 01), todayDate);
            var ba2 = new BirthdateAnalyser(new DateTime(2022, 12, 22), todayDate);
            var ba3 = new BirthdateAnalyser(new DateTime(1803, 01, 01), todayDate);


            //Act
            var actual1 = ba1.ValidateBirthdate();
            var actual2 = ba2.ValidateBirthdate();
            var actual3 = ba3.ValidateBirthdate();

            //Assert
            Assert.True(actual1);
            Assert.False(actual2);
            Assert.False(actual3);
        }
    }
}
