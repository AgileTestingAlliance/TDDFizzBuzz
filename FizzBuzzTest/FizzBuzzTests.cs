using FizzBuzz;
using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        
        
        [Fact]
      
        public void ShouldProcess()
        {
            FizzBuzzClass fbObj = new FizzBuzzClass();
            fbObj.Process(7).Should().Be("7");
            fbObj.Process(3).Should().Be("Fizz");
            fbObj.Process(5).Should().Be("Buzz");
            fbObj.Process(30).Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4, 6, 7, 19, 10, 12, 15, 30, 31 })]
        public void ShouldExecute(int[] data)
        {
            FizzBuzzClass fbObj = new FizzBuzzClass();
            fbObj.Execute(data).Should().Be("1,2,4,Fizz,7,19,Buzz,Fizz,FizzBuzz,FizzBuzz,31");
        }



          

    }
}
