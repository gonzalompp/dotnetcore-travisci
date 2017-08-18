using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
		[Fact]
		public void Add()
        {
			int a = 2;
			int b = 2;
			int result = Calculator.Add(a,b);

			Assert.True(result == 4);
        }

		[Fact]
		public void SubtractPositives()
		{
			int a = 2;
			int b = 2;
			int result = Calculator.Subtract(a,b);

			Assert.True(result == 0);
		}

    }
}
