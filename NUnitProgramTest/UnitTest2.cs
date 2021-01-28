using NUnit.Framework;
using Individual_Task_Variant_7;

namespace NUnitProgramTest
{
    public class UnitTest2 : Person
    {
        [Test]
        public void ValidateCorrectStringTest()
        {
            UnitTest2 unitTest = new UnitTest2();

            bool isStringCorrect = unitTest.ValidateString("Bohdan");

            Assert.IsTrue(isStringCorrect);
        }

        [Test]
        public void ValidateStringWithDigitTest()
        {
            UnitTest2 unitTest = new UnitTest2();

            bool isStringCorrect = unitTest.ValidateString("Bohdan123");

            Assert.IsFalse(isStringCorrect);
        }

        [Test]
        public void ValidateStringWithReservedCharactersTest()
        {
            UnitTest2 unitTest = new UnitTest2();

            bool isStringCorrect = unitTest.ValidateString("Bohdan*!.-%$");

            Assert.IsFalse(isStringCorrect);
        }

        [Test]
        public void ValidateEmptyStringTest()
        {
            UnitTest2 unitTest = new UnitTest2();

            bool isStringCorrect = unitTest.ValidateString("");

            Assert.IsFalse(isStringCorrect);
        }
    }
}
