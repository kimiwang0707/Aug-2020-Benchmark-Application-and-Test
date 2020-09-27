using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject_D201BenchmarkApp
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod_Add()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_Add();
            this.UIMap.AssertMethod_Add();
         
        }

        [TestMethod]
        public void CodedUITestMethod_IllegalInput()
        {
            this.UIMap.RecordedMethod_IllegalIdInput();
            this.UIMap.AssertMethod_IllegalIdInput();

            this.UIMap.RecordedMethod_IllegalNameInput();
            this.UIMap.AssertMethod_IllegalNameInput();

            this.UIMap.RecordedMethod_IllegalEmailInput();
            this.UIMap.AssertMethod_lllegalEmailInput();

            this.UIMap.RecordedMethod_IllegalDOB();
            this.UIMap.AssertMethod_IllegalDOB();

            this.UIMap.RecordedMethod_IllegalSalaryInput();
            this.UIMap.AssertMethod_IllegalSalaryInput();
            this.UIMap.RecordedMethod_CloseReminder();



        }

        [TestMethod]
        public void CodedUITestMethod_Sort()
        {

            this.UIMap.RecordedMethod_Ascending();
            this.UIMap.AssertMethod_Ascending();
            
            this.UIMap.RecordedMethod_Descending();
            this.UIMap.AssertMethod_Descending();          
        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
