using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCode;
using NUnit;
using NUnit.Framework;

namespace UnitTestProjectDemos
{
    [TestFixture]
    public class RekenMachineTests
    {
        private RekenMachine _rekenmachine;

        [SetUp]
        public void SetUp()
        {
            _rekenmachine = new RekenMachine();
        }

        [Test]
        public void Add_GegevenTweeGetallen_ReturnSom()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act 

            int result = _rekenmachine.Add(a, b);
            int expected = 3;

            //Assert 
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sub_GegevenTweeGetallen_ReturnVerschil()
        {
            //Arange
            int a = 2;
            int b = 1;
            //Act
            int result = _rekenmachine.Sub(a,b);
            int expected = 1;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Mult_GegevenTweeGetallen_ReturnProduct()
        {
            //Arange
            int a = 2;
            int b = 1;
            //Act
            int result = _rekenmachine.Mult(a, b);
            int expected = 2;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Div_GegevenTweeGetallen_ReturnDivision()
        {
            //Arange
            int a = 2;
            int b = 1;
            //Act
            int result = _rekenmachine.Div(a, b);
            int expected = 2;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]

        public void Delen_OpNull()
        {
            ////Arrange
            //int a = 2;
            //int b = 0;
            Assert.Throws<DivideByZeroException>(() => _rekenmachine.Div(2, 0));
        }

        [TestCase(0,false)]
        [TestCase(1,true)]
        [TestCase(50,true)]
        [TestCase(101,false)]
        [TestCase(-1,false)]
        [TestCase(1000,false)]
        public void IsInRange_ShouldValidateCorrectRange(int number, bool expeted)
        {
            //Act
            bool result = _rekenmachine.IsInRange(number);
            //Assert
            Assert.That(expeted, Is.EqualTo(result));
        }
    }
}
