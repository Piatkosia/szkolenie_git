using System;
using Xunit;
using Shouldly;
namespace MathWorkshop.Tests
{
    public class MathTest
    {
        public MathTest()
        {

        }
        Math testobject;
        int testvalue = 7;
        [Fact]
        public void Math_Value_SetCorrectly()
        {
            Arrange_Math_Value_SetCorrectly();
            Act_Math_Value_SetCorrectly();
            Assert_Math_Value_SetCorrectly();
        }

        private void Assert_Math_Value_SetCorrectly()
        {
            testobject.Value.ShouldBe(testvalue);
        }

        private void Act_Math_Value_SetCorrectly()
        {
            testobject.Value = testvalue;
        }

        private void Arrange_Math_Value_SetCorrectly()
        {
            testobject = new Math();
        }
    }
}