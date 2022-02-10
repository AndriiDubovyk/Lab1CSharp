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
    }
}
