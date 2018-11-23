using Microsoft.VisualStudio.TestTools.UnitTesting;
using M06_Davis_HospitalCharges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06_Davis_HospitalCharges.Tests
{
    [TestClass()]
    public class HospitalChargesTests
    {
        [TestMethod()]
        public void CalcStayChargesTestIsValid()
        {
            var testClass = new HospitalCharges();
            int expected = 700;

            var result = testClass.CalcStayCharges("2");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Please enter a valid number into the days box.")]
        public void CalcStayChargesTestErrorMsgThrown()
        {
            var testClass = new HospitalCharges();
            int expected = 700;

            var result = testClass.CalcStayCharges("-2");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CalcMiscChargesValidInput()
        {
            var testClass = new HospitalCharges();
            int expected = 2825;

            var result = testClass.CalcMiscCharges("425","1250","350","800");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Please enter a valid number into the lab fees box.")]
        public void CalcMiscChargesInvalidFirst()
        {
            var testClass = new HospitalCharges();
            int expected = 2825;

            var result = testClass.CalcMiscCharges("-1", "1250", "350", "800");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Please enter a valid number into the surgical box.")]
        public void CalcMiscChargesInvalidSecond()
        {
            var testClass = new HospitalCharges();
            int expected = 2825;

            var result = testClass.CalcMiscCharges("425", "-1", "350", "800");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Please enter a valid number into the medication box.")]
        public void CalcMiscChargesInvalidThird()
        {
            var testClass = new HospitalCharges();
            int expected = 2825;

            var result = testClass.CalcMiscCharges("425", "1250", "-1", "800");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Please enter a valid number into the rehab box.")]
        public void CalcMiscChargesInvalidFourth()
        {
            var testClass = new HospitalCharges();
            int expected = 2825;

            var result = testClass.CalcMiscCharges("425", "1250", "350", "-1");

            Assert.AreEqual(expected, result);
        }




    }
}