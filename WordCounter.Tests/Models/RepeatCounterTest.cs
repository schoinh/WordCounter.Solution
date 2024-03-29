using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void ValidInput_CheckForSpaces_False()
        {
            bool output = RepeatCounter.ValidInput("which milk");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void ValidInput_CheckForSpecialChars_False()
        {
            bool output = RepeatCounter.ValidInput("milk?");
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void ValidInput_RecognizeValidInput_True()
        {
            bool output = RepeatCounter.ValidInput("milk");
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void Count_Counts1Repeat_1()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "milk");
            int output = newCounter.Count();
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void Count_Counts1RepeatOnlyFullWord_0()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "milky");
            int output = newCounter.Count();
            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void Count_Counts1RepeatInMultiWordSentence_1()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "I like milk");
            int output = newCounter.Count();
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void Count_CountsMultipleRepeatsInMultiWordSentence_2()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "I like almond milk and rice milk");
            int output = newCounter.Count();
            Assert.AreEqual(2, output);
        }

        [TestMethod]
        public void Count_Counts1RepeatWithPunctuation_1()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "I like milk.");
            int output = newCounter.Count();
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void Count_CountsMultipleRepeatsWithPunctuation_3()
        {
            RepeatCounter newCounter = new RepeatCounter("milk", "I like soy milk, almond milk, and oat milk.");
            int output = newCounter.Count();
            Assert.AreEqual(3, output);
        }
    }
}