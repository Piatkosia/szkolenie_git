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
        Action testAction;
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

        [Fact]
        public void Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException()
        {
            Arrange();
            Act_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException();
            Assert_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException();
        }

        private void Assert_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException()
        {
           testAction.ShouldThrow<Exception>();
        }

        private void Act_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException()
        {
            testobject.Value = Int32.MaxValue;
            testAction = () => testobject.Add(valueToAdd);
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