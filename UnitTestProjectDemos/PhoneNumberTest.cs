using ClassLibraryCode;
using NUnit.Framework;
using System;
namespace UnitTestProjectDemos
{
    [TestFixture]
    public class PhoneNumberTest
    {
        [Test]
        public void Parse_ValidNumber_ReturnsPhoneNumber()
        {
            // Arrange
            var validNumber = "1234567890";

            // Act
            var phoneNumber = PhoneNumber.Parse(validNumber);

            // Assert
            Assert.That(phoneNumber.Area, Is.EqualTo("123"));
            Assert.That(phoneNumber.Major, Is.EqualTo("456"));
            Assert.That(phoneNumber.Minor, Is.EqualTo("7890"));
        }

        [Test]
        public void Parse_EmptyOrNull_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(""));
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(null));
        }

        [Test]
        public void Parse_InvalidLength_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse("123456789"));
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse("12345678901"));
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var phoneNumber = new PhoneNumber("123", "456", "7890"); // Let op: dit vereist wijziging van de constructor naar public.
            var result = phoneNumber.ToString();
            Assert.That(result, Is.EqualTo("(123)456-7890"));
        }
    }
}
