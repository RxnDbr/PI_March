using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DayTest and is intended
    ///to contain all DayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DayTest
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        internal virtual Day CreateDay()
        {
            // TODO: Instantiate an appropriate concrete class.
            int[] click = {700,1000};
            Place hq = new Place(0.0, 0.0, "HQ", click);
            Day target = new Future(1, hq);
            return target;
        }

        /// <summary>
        ///A test for modifyHoursActivity
        ///</summary>
        [TestMethod()]
        public void modifyHoursActivityTest()
        {
            Day target = CreateDay(); // TODO: Initialize to an appropriate value       
            Activity prevActivity = new Inside(5,9,target.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            target.addActivity(prevActivity);
            int newStart = 6; // TODO: Initialize to an appropriate value
            int newEnd = 9; // TODO: Initialize to an appropriate value
            target.modifyHoursActivity(prevActivity, newStart, newEnd);

            Day test = CreateDay();
            List<Activity> expected = test.L_activity;
            for (int i = 6; i <= 9; i++)
            {
                expected[i] = new Inside(6, 9, target.Map_hq, "coucou");
            }
            Assert.AreEqual(expected, target.L_activity);
            
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sortActivityList
        ///</summary>
        [TestMethod()]
        public void sortActivityListTest()
        {
            Day target = CreateDay(); // TODO: Initialize to an appropriate value
            target.sortActivityList();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for addActivity
        ///</summary>
        [TestMethod()]
        public void addActivityTest()
        {
            Day targetDay = CreateDay(); // TODO: Initialize to an appropriate value
            Day expectedDay = CreateDay();

            int startActivity = 5;
            int endActivity = 9;

            Activity defaultActivity1 = new Inside(0, startActivity, targetDay.Map_hq);
            Activity newActivity = new Inside(startActivity, endActivity, targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            Activity defaultActivity2 = new Inside(endActivity, expectedDay.L_activity.Count-1, targetDay.Map_hq);

            List<Activity> expected = expectedDay.L_activity;
            int i;
            for (i=0; i<startActivity; i++) {expected[i] = defaultActivity1; }
            for (i = startActivity; i < endActivity; i++) { expected[i] = newActivity; }
            for (i=endActivity; i<expectedDay.L_activity.Count; i++){expected[i] = defaultActivity2;}


            targetDay.addActivity(newActivity);

            CollectionAssert.AreEqual(expected, targetDay.L_activity);
        }
    }   
}
