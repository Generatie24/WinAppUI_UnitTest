using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemos
{
    [TestFixture]
    public class ListProcessorTests
    {
        private ListProcessor _listProcessor;
        private List<String> _list;
        private List<String> _list1;

        [SetUp] 
        public void SetUp() 
        {
            _listProcessor = new ListProcessor();
            _list = new List<String> {"a","b", "c","a"};
            _list1 = new List<string> { "appel", "banaan", "citroen", "aardbei" };

        }

        [Test]
        public void SortList_ShouldReturnSortedList()
        {
            //Arange
            //var inputlist = _list;
            //Act
            //var result = _listProcessor.SortList(inputlist);
            //Assert
            Assert.That(_listProcessor.SortList(_list), Is.EqualTo(new List<string> { "a", "a","b", "c"}));
        }

        [TestCase("a", new[] { "appel", "banaan", "aardbei" })]
        [TestCase("c", new[] { "citroen" })]
        [TestCase("x", new string[0])]
        public void FindStringsWithSubstring_ShouldReturnCorrectStrings(string substring, 
            string[] expected)
        {
            // Act
            var result = _listProcessor.FindStringWithSubstring(_list1, substring);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
