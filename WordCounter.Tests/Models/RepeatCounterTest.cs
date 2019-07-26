using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
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
    }
}