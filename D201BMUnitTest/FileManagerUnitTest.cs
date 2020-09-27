// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D201BenchmarkApp;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace D201BMUnitTest
{
    /// <summary>
    /// Test FileManager
    /// </summary>
    [TestClass]
    public class FileManagerUnitTest
    {
        /// <summary>
        /// Test file save function
        /// </summary>
        [TestMethod]
        public void TestSaveFiles()
        {
            //Create 3 staff
            MyClass c1 = new MyClass();
            c1.Id = 2020089;
            c1.Staff_Name = "Danny Wong";
            c1.Birthday = "17/08/2000";
            c1.Email = "dannywong@gmail.com";
            c1.Salary = 19800;
            
            MyClass c2 = new MyClass();
            c2.Id = 2020090;
            c2.Staff_Name = "Fanny Wong";
            c2.Birthday = "17/08/2000";
            c2.Email = "fannywong@gmail.com";
            c2.Salary = 19800;

            MyClass c3 = new MyClass();
            c3.Id = 2020091;
            c3.Staff_Name = "Yanny Wong";
            c3.Birthday = "17/08/2000";
            c3.Email = "yannywong@gmail.com";
            c3.Salary = 19800;
           
            // Add all staff in list.
            List<MyClass> cList = new List<MyClass>();
            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);

            FileManager.SaveFiles(cList);
            //Use save fucntion to check if all staff creating is equal to the document in Staff.txt.
            string s = System.IO.File.ReadAllText("Staff.txt");
            Assert.AreEqual("2020089,Danny Wong,17/08/2000,dannywong@gmail.com,19800"+
                "2020090,Fanny Wong,17/08/2000,fannywong@gmail.com,19800"+
            "2020091,Yanny Wong,17/08/2000,yannywong@gmail.com,19800", s.ToString().Replace("\r\n", ""));
        }

        
        /// <summary>
        /// Test save selected staff information.
        /// </summary>
        [TestMethod]
        public void TestSaveCreatures()
        {
            // Create a staff.
            MyClass c1 = new MyClass();
            c1.Id = 2020089;
            c1.Staff_Name = "Alice Wong";
            c1.Birthday = "17/08/2000";
            c1.Email = "alicewong01@gmail.com";
            c1.Salary = 19800;
            // Add staff to list.
            List<MyClass> cList = new List<MyClass>();
            cList.Add(c1);

            //Use the saveCreature function to check if the information saved is equal to the document produced.
            FileManager fm = new FileManager();
            bool SaveCreatures = fm.SaveCreature(c1, "2020089 Alice Wong.txt");
            Assert.IsTrue(SaveCreatures);
        }

       


    }
}
