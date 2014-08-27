using System;
//using ClassLibrary1;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    

    [TestClass]
    public class UnitTest1
    {
        private ClassLibrary1.Person _p;

        [TestInitialize]
        public void BeginTest()
        {
            _p = new Person("Magne");
        }

        [TestMethod]
        public void TestAdult()
        {
            // Under 18 should return false
            _p.Age =  17.99;
            bool result = _p.isAdult();
            Assert.IsFalse(result);

            // Equal to 18 should return true
            _p.Age = 18.00;
            result = _p.isAdult();
            Assert.IsTrue(result);

            // Over 18 should return true
            _p.Age =  18.01;
            result = _p.isAdult();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEquality()
        {
            Person p = new Person();
            p.Name = "Børge";
            p.Age = 24;
            Person o = p;
            Person otherP = new Person("Børge");
            otherP.Age = 24;

            Assert.AreEqual(p, otherP);

        }
       
        [TestMethod]
        public void TestEquality1()
        {
            Person p = new Person();
            p.Name = "Børge";
            p.Age = 24;
            Person o = p;
            Person otherP = new Person("ben");
            otherP.Age = 24;


            Assert.AreNotEqual(p, otherP);


        }
        [TestMethod]
        public void TestEquality2()
        {
            Person p = new Person();
            p.Name = "Børge";
            p.Age = 24;
            Person o = p;
            Person otherP = new Person("børge");
            otherP.Age = 35;


            Assert.AreNotEqual(p, otherP);


        }
        [TestMethod]
        public void TestEquality3()
        {
            Person p = new Person();
            p.Name = "Børge";
            p.Age = 25;
            Person o = p;
            Person otherP = new Person("ben");
            otherP.Age = 24;


            Assert.AreNotEqual(p, otherP);


        }

        [TestMethod]
        public void TestEquality4()
        {
            Person p = new Person();
            p.Name = "Børge";
            p.Age = 24;
            string ab = "børge 24";

            Assert.AreNotEqual(p, ab);
        }
    }
}
