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
        int initValue = 7;
        int valueToAdd = 1;
        int valueAfterAdding = 8;
        [Fact]
        public void Math_Value_WhenTestValueIsSet_TestValue()
        {
            Arrange();
            Act_Math_Value_WhenTestValueIsSet_TestValue();
            Assert_Math_Value_WhenTestValueIsSet_TestValue();
        }
        [Fact]
        public void Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne()
        {
            Arrange();
            Act_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne();
            Assert_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne();
        }

        private void Assert_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne()
        {
            testobject.Value.ShouldBe(valueAfterAdding);
        }

        private void Act_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne()
        {
            testobject.Value = initValue;
            testobject.Add(valueToAdd);
        }

        private void Assert_Math_Value_WhenTestValueIsSet_TestValue()
        {
            testobject.Value.ShouldBe(initValue);
        }

        private void Act_Math_Value_WhenTestValueIsSet_TestValue()
        {
            testobject.Value = initValue;
        }

        private void Arrange()
        {
            testobject = new Math();
        }
    }
}