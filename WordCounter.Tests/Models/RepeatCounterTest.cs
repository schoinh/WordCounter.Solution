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
    }
}