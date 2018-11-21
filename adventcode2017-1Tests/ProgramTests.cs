using Microsoft.VisualStudio.TestTools.UnitTesting;
using adventcode2017_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventcode2017_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        const string testInput1 = "1122";
        const string testInput2 = "1111";
        const string testInput3 = "1234";
        const string testInput4 = "91212129";

        const int testOutput1 = 3;
        const int testOutput2 = 4;
        const int testOutput3 = 0;
        const int testOutput4 = 9;

        [TestMethod]
        public void getSumTest1()
        {
            int[] intArray1 = adventcode2017_1.Program.ConvertStringToIntArray(testInput1);
            Assert.AreEqual(testOutput1, adventcode2017_1.Program.getSum(intArray1));
        }

        [TestMethod]
        public void getSumTest2()
        {
            int[] intArray2 = adventcode2017_1.Program.ConvertStringToIntArray(testInput2);
            Assert.AreEqual(testOutput2, adventcode2017_1.Program.getSum(intArray2));
        }

        [TestMethod]
        public void getSumTest3()
        {
            int[] intArray3 = adventcode2017_1.Program.ConvertStringToIntArray(testInput3);
            Assert.AreEqual(testOutput3, adventcode2017_1.Program.getSum(intArray3));
        }
        [TestMethod]
        public void getSumTest4()
        {
            int[] intArray4 = adventcode2017_1.Program.ConvertStringToIntArray(testInput4);
            Assert.AreEqual(testOutput4, adventcode2017_1.Program.getSum(intArray4));
        }

    }
}