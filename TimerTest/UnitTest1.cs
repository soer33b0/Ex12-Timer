﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex12_Timer;

namespace TimerTest
{
    [TestClass]
    public class UnitTest1
    {
        private Timer timer;

        [TestInitialize]
        public void SetupForTest()
        {
            timer = new Timer();
        }

        [TestMethod]
        public void ShouldInitializeToZero()
        {
            Assert.AreEqual(0, timer.Seconds);
        }
        [TestMethod]
        public void ShouldDisplay0SecondsToStringAs00ː00ː00()
        {
            timer.Seconds = 0;
            Assert.AreEqual("00:00:00", timer.ToString());
        }
        [TestMethod]
        public void ShouldDisplay12SecondsToStringAs00ː00ː12()
        {
            timer.Seconds = 12;
            Assert.AreEqual("00:00:12", timer.ToString());
        }

        [TestMethod]
        public void ShouldDisplay66SecondsToStringAs00ː01ː06()
        {
            timer.Seconds = 66;
            Assert.AreEqual("00:01:06", timer.ToString());
        }
        [TestMethod]
        public void ShouldDisplay4000SecondsToStringAs01ː40ː06()
        {
            timer.Seconds = 4000;
            Assert.AreEqual("01:06:40", timer.ToString());
        }

        
       [TestMethod]
        public void PadsZero()
        {
            Assert.AreEqual("00", timer.Padded(0));
        }
        [TestMethod]
        public void PadsOne()
        {
            Assert.AreEqual("01", timer.Padded(1));
        }
        [TestMethod]
        public void DoesNotPad()
        {
            Assert.AreEqual("12", timer.Padded(12));
        }
    }

}
