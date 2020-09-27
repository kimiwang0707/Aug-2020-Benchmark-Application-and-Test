// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D201BenchmarkApp;
using System.Collections.Generic;

namespace D201BMUnitTest
{
    [TestClass]
    public class FilterUnitTest
    {       
        /// <summary>
        /// Test Filter ascending sort function
        /// </summary>
        [TestMethod]
        public void TestFilterSortAZ()
        {
            // Create four staff
            MyClass c1 = new MyClass();
            c1.Id = 2020089;
            c1.Staff_Name = "Aily Wong";
            c1.Birthday = "17/08/2000";
            c1.Email = "lilywong01@gmail.com";
            c1.Salary = 19800;          

            MyClass c2 = new MyClass();
            c2.Id = 2020089;
            c2.Staff_Name = "Cily Wong";
            c2.Birthday = "17/08/2000";
            c2.Email = "lilywong01@gmail.com";
            c2.Salary = 19800;

            MyClass c3 = new MyClass();
            c3.Id = 2020089;
            c3.Staff_Name = "Gily Wong";
            c3.Birthday = "17/08/2000";
            c3.Email = "lilywong01@gmail.com";
            c3.Salary = 19800;

            MyClass c4 = new MyClass();
            c4.Id = 2020089;
            c4.Staff_Name = "Lily Wong";
            c4.Birthday = "17/08/2000";
            c4.Email = "lilywong01@gmail.com";
            c4.Salary = 19800;

            //Expected sort order.
            List<MyClass> cListExpected = new List<MyClass>();
            cListExpected.Add(c1);
            cListExpected.Add(c2);
            cListExpected.Add(c3);
            cListExpected.Add(c4);

            //Add the staff in list according to this order.
            List<MyClass> cList = new List<MyClass>();
            cList.Add(c3);
            cList.Add(c2);
            cList.Add(c1);
            cList.Add(c4);

            //Test if can achieve SortAZ function
            Filter f = new Filter();
            cList = f.SortAZ(cList);
            CollectionAssert.AreEqual(cListExpected, cList);

        }

        /// <summary>
        /// Test Filter descending sort function
        /// </summary>
        [TestMethod]
        public void TestFilterSortZA()
        {
            //Add four staff
            MyClass c1 = new MyClass();
            c1.Id = 2020089;
            c1.Staff_Name = "Aily Wong";
            c1.Birthday = "17/08/2000";
            c1.Email = "lilywong01@gmail.com";
            c1.Salary = 19800;

            MyClass c2 = new MyClass();
            c2.Id = 2020089;
            c2.Staff_Name = "Cily Wong";
            c2.Birthday = "17/08/2000";
            c2.Email = "lilywong01@gmail.com";
            c2.Salary = 19800;

            MyClass c3 = new MyClass();
            c3.Id = 2020089;
            c3.Staff_Name = "Gily Wong";
            c3.Birthday = "17/08/2000";
            c3.Email = "lilywong01@gmail.com";
            c3.Salary = 19800;

            MyClass c4 = new MyClass();
            c4.Id = 2020089;
            c4.Staff_Name = "Lily Wong";
            c4.Birthday = "17/08/2000";
            c4.Email = "lilywong01@gmail.com";
            c4.Salary = 19800;

            //Expected sort order.
            List<MyClass> cListExpected = new List<MyClass>();
            cListExpected.Add(c4);
            cListExpected.Add(c3);
            cListExpected.Add(c2);
            cListExpected.Add(c1);

            //Add staff in this order to list.
            List<MyClass> cList = new List<MyClass>();
            cList.Add(c3);
            cList.Add(c2);
            cList.Add(c1);
            cList.Add(c4);

            //Test if can achieve SortZA function.
            Filter f = new Filter();
            cList = f.SortZA(cList);
            CollectionAssert.AreEqual(cListExpected, cList);
        }

        /// <summary>
        /// Test Search function
        /// </summary>
        [TestMethod]
        public void TestFilterSearch()
        {
            //Add four staff name
            MyClass c1 = new MyClass();
            c1.Staff_Name = "Aiby";

            MyClass c2 = new MyClass();
            c2.Staff_Name = "Ciby";

            MyClass c3 = new MyClass();
            c3.Staff_Name = "Liby";

            MyClass c4 = new MyClass();
            c4.Staff_Name = "Hito";

            //Add staff in list
            List<MyClass> cList = new List<MyClass>();
            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);
            cList.Add(c4);

            //Create a filter to check if can search name by key words.
            Filter f = new Filter();
            List<MyClass> searchResults = new List<MyClass>();
            searchResults = f.Search(cList, "by");

            CollectionAssert.Contains(searchResults, c1);
            CollectionAssert.Contains(searchResults, c2);
            CollectionAssert.Contains(searchResults, c3);
            CollectionAssert.DoesNotContain(searchResults, c4);
        }

    }
}
