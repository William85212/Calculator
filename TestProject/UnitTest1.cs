using Calculator;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 1, 2, 4, 3, 2 };
            int sum = Calculator.Calculator.SumEvens(nums);
            Assert.Equal(8, sum);
        }
    }
}
