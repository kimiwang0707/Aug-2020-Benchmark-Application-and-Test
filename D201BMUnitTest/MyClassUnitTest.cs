// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D201BenchmarkApp;

namespace D201BMUnitTest
{
    /// <summary>
    /// Test MyClass
    /// </summary>
    [TestClass]
    public class MyClassUnitTest
    {
        /// <summary>
        /// Test Staff ID
        /// </summary>  
        [TestMethod]
        public void TestStaffId()
        {
            MyClass c = new MyClass();
            c.Id = 201208;
            Assert.AreEqual(201208, c.Id);
        }

        /// <summary>
        /// Test Staff Name
        /// </summary>
        [TestMethod]
        public void TestStaffName()
        {
            MyClass c = new MyClass();
            c.Staff_Name = "Stephen Leung";
            Assert.AreEqual("Stephen Leung", c.Staff_Name);
        }

        /// <summary>
        /// Test Staff Date of Birth
        /// </summary>
        [TestMethod]
        public void TestStaffBirthday()
        {
            MyClass c = new MyClass();
            c.Birthday = "28/09/1998";
            Assert.AreEqual("28/09/1998", c.Birthday);
        }

        /// <summary>
        /// Test Staff Email address
        /// </summary>
        [TestMethod]
        public void TestStaffEmail()
        {
            MyClass c = new MyClass();
            c.Email = "jimtom@hotmail.com";
            Assert.AreEqual("jimtom@hotmail.com", c.Email);
        }

        /// <summary>
        /// Test Staff Salary
        /// </summary>
        [TestMethod]
        public void TestStaffSalary()
        {
            MyClass c = new MyClass();
            c.Salary = 18900;
            Assert.AreEqual(18900, c.Salary);
        }

        /// <summary>
        /// Test Staff constructor
        /// </summary>
        [TestMethod]
        public void TestStaffConstructor()
        {
            MyClass c = new MyClass();
            Assert.AreEqual(0, c.Id, "ID fail");
            Assert.AreEqual("NA", c.Staff_Name, "Name fail");
            Assert.AreEqual("NA", c.Birthday, "Birthday fail");
            Assert.AreEqual("NA", c.Email, "Email fail");
            Assert.AreEqual(0, c.Salary, "Salary fail");
        }

        /// <summary>
        /// Test staff information format conversion
        /// </summary>
        [TestMethod]
        public void TestStaffToStringFormat()
        {
            MyClass c = new MyClass();
            c.Id = 2020089;
            c.Staff_Name = "Lily Wong";
            c.Birthday = "17/08/2000";
            c.Email = "lilywong01@gmail.com";
            c.Salary = 19800;
            Assert.AreEqual("2020089 Lily Wong 17/08/2000 lilywong01@gmail.com $19800", c.ToString());
        }


    }
}
