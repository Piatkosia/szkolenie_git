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
        Action testAction;
        [Theory]
        [InlineData(7)]
        public void Math_Value_WhenTestValueIsSet_TestValue(int initval)
        {
            Arrange();
            Act_Math_Value_WhenTestValueIsSet_TestValue(initval);
            AssertIfRetval(initval);
        }
        [Theory]
        [InlineData(7,1,8)]
        [InlineData(-10,1,-9)]
        public void Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne(int initval, int addedval, int retval)
        {
            Arrange();
            Act_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne(initval, addedval);
            AssertIfRetval(retval);
        }

        [Theory]
        [InlineData(7,1,6)]
        public void Math_SubValue_WhenOneIsSubst_ReturnsTestValue_MinusOne(int initval, int subbedval, int retval)
        {
            Arrange();
            Act_Math_SubValue_WhenOneIsSubst_ReturnsTestValue_MinusOne(initval, subbedval);
            AssertIfRetval(retval);
        }
        [Theory]
        [InlineData(1)]
        public void Math_SubValue_WhenOneIsSub_AndInitialIsMin_ThrowsException(int subbed)
        {
            Arrange();
            Act_Math_SubValue_WhenOneIsSub_AndInitialIsMin_ThrowsException(subbed);
            AssertIfException();
        }
        private void Act_Math_SubValue_WhenOneIsSubst_ReturnsTestValue_MinusOne(int initval, int subbedval)
        {
             testobject.Value = initval;
             testobject.Sub(subbedval);
        }

        [Theory]
        [InlineData(1)]
        public void Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException(int addedval)
        {
            Arrange();
            Act_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException(addedval);
            AssertIfException();
        }
        private void Act_Math_SubValue_WhenOneIsSub_AndInitialIsMin_ThrowsException(int subbedval)
        {
            testobject.Value = Int32.MinValue;
            testAction = () => testobject.Sub(subbedval);
        }

        private void AssertIfException()
        {
           testAction.ShouldThrow<Exception>();
        }

        private void Act_Math_AddValue_WhenOneIsAdd_AndInitialIsMax_ThrowsException(int valueToAdd)
        {
            testobject.Value = Int32.MaxValue;
            testAction = () => testobject.Add(valueToAdd);
        }

        private void AssertIfRetval(int returnValue)
        {
            testobject.Value.ShouldBe(returnValue);
        }

        private void Act_Math_AddValue_WhenOneIsAdd_ReturnsTestValue_PlusOne(int initValue, int valueToAdd)
        {
            testobject.Value = initValue;
            testobject.Add(valueToAdd);
        }

        private void Act_Math_Value_WhenTestValueIsSet_TestValue(int initValue)
        {
            testobject.Value = initValue;
        }

        private void Arrange()
        {
            testobject = new Math();
        }
    }
}