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
            var ba1 = new BirthdateAnalyser(new DateTime(2003, 08, 01));
            var ba2 = new BirthdateAnalyser(new DateTime(2000, 02, 10));

            var expected1 = 18;
            var expected2 = 22;

            //Act
            var actual1 = ba1.GetAge();
            var actual2 = ba2.GetAge();

            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }
    }
}
