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
        public void Math_Value_WhenTestValueIsSet_TestValue()
        {
            Arrange_Math_Value_WhenTestValueIsSet_TestValue();
            Act_Math_Value_WhenTestValueIsSet_TestValue();
            Assert_Math_Value_WhenTestValueIsSet_TestValue();
        }

        private void Assert_Math_Value_WhenTestValueIsSet_TestValue()
        {
            testobject.Value.ShouldBe(testvalue);
        }

        private void Act_Math_Value_WhenTestValueIsSet_TestValue()
        {
            testobject.Value = testvalue;
        }

        private void Arrange_Math_Value_WhenTestValueIsSet_TestValue()
        {
            testobject = new Math();
        }
    }
}