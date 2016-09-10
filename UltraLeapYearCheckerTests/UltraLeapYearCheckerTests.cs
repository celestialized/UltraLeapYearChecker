using UltraLeapYearChecker;
using Xunit;

namespace UltraLeapYearCheckerTests
{
	public class UltraLeapYearCheckerTests
	{
		[Fact]
		public void ShouldRerturnFalseForTypicalCommonYear()
		{
			var checker = new LeapYearChecker();
			var result = checker.IsLeapYear(2001);
			Assert.False(result);
		}
	}
}