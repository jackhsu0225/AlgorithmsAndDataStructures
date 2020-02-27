﻿using System;
using NUnit.Framework;

namespace StringManipulation.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString2_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString2(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString3_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString3(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("   ", 0)]
        [TestCase("HaeiouHAEIOUh", 10)]
        public void CountVowels_WhenCalled_ReturnsNumberOfVowels(string input, int expectedResult)
        {
            var result = _stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Trees are beautiful", "beautiful are Trees")]
        [TestCase("   Trees are beautiful", "beautiful are Trees")]
        [TestCase("Trees are beautiful   ", "beautiful are Trees")]
        [TestCase("Trees   are beautiful", "beautiful are   Trees")]
        [TestCase("Trees", "Trees")]
        public void ReverseWords_WhenCalled_ReturnsReversedWords(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseWords(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Trees are beautiful", "beautiful are Trees")]
        [TestCase("   Trees are beautiful", "beautiful are Trees")]
        [TestCase("Trees are beautiful   ", "beautiful are Trees")]
        [TestCase("Trees   are beautiful", "beautiful are   Trees")]
        [TestCase("Trees", "Trees")]
        public void ReverseWords2_WhenCalled_ReturnsReversedWords(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseWords2(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase(null, "", false)]
        [TestCase("", null, false)]
        [TestCase(" ", " ", true)]
        [TestCase("ABCD", "ABCD", true)]
        [TestCase("ABCD", "DABC", true)]
        [TestCase("ABCD", "CDAB", true)]
        [TestCase("BAACD", "DBAAC", true)]
        [TestCase("BABAB", "ABBAB", true)]
        [TestCase("ABCD", "DCAB", false)]
        [TestCase("ABCD", "ABCDE", false)]
        public void AreRotations_WhenCalled_ReturnsAreRotations(string str1, string str2, bool expectedResult)
        {
            var result = _stringUtils.AreRotations(str1, str2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", " ")]
        [TestCase("Trees are beautiful", "Tres abutifl")]
        public void RemoveDuplicates_WhenCalled_ReturnsNoneDuplicateString(string str, string expectedResult)
        {
            var result = _stringUtils.RemoveDuplicates(str);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
