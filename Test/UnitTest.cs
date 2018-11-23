using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            var target = new ViewModel();

            var events = new List<string>();

            target.PropertyChanged += (sender, args) =>
            {
                events.Add(args.PropertyName);
            };

            target.Property1 = 3;
            target.Property2 = "Test";

            Assert.AreEqual(2, events.Count);
            Assert.AreEqual("Property1", events[0]);
            Assert.AreEqual("Property2", events[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test2()
        {
            var target = new ViewModel();

            target.Property2 = null;
        }
    }
}
