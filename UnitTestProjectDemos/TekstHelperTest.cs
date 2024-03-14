using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryCode.TekstHelper;

namespace UnitTestProjectDemos
{
    [TestFixture]
    public class TekstHeleperTests
    {
        private TekstHelper _tekstHelper;
        [SetUp]
        public void Setup()
        {
            _tekstHelper = new TekstHelper();
        }

        [Test]
        public void Lengte_GegevenString_RetourneertLengte()
        {
            //Arrange
            string input = "Hallo";
            int expected = 5;
            //Act
            int lengte = _tekstHelper.Lengte(input);
            //Assert
            Assert.That(lengte, Is.EqualTo(expected));
        }

        [Test]
        public void Omkeren_GegevenString_ReturnOmgekeerde()
        {
            string result = _tekstHelper.Omkeren("Hallo");
            Assert.That(result, Is.EqualTo("ollaH"));
        }

        [Test]
        public void NaarHoofdletters_GegevenString_RetourneertStringInHoofdletters()
        {
            string resultaat = _tekstHelper.NaarHoofdletters("Hallo");
            Assert.That(resultaat, Is.EqualTo("HALLO"));
        }

        [Test]
        public void IsLeeg_GegevenLegeString_RetourneertTrue()
        {
            bool resultaat = _tekstHelper.IsLeeg("");
            Assert.That(resultaat, Is.EqualTo(true));
        }

        //[Ignore("Because I just want it")]

        [Test]
        public void Samenvoegen_GegevenTweeStrings_RetourneertSamengevoegdeString()
        {
            string resultaat = _tekstHelper.Samenvoegen("Hallo", "Wereld");
            Assert.That(resultaat, Is.EqualTo("HalloWereld"));
        }

        [TestCase(1, "Positief")]
        [TestCase(-1, "Negatief")]
        [TestCase(0, "Nul")]
        public void Analyze_ShouldIdentifyNumberCorrectly(int number, string expectedResult)
        {
            // Act
            string result = _tekstHelper.Analyze(number);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
