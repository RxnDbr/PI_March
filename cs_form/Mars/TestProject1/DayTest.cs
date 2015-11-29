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

        internal virtual Future CreateDay()
        {
            // TODO: Instantiate an appropriate concrete class.
            int[] click = {700,1000};
            Place hq = new Place(0.0, 0.0, "HQ", click);
            Future target = new Future(1, hq);
            return target;
        }
        /// <summary>
        ///A test for addActivity
        ///</summary>
        [TestMethod()]
        public void addActivityTest()
        {
            Future targetDay = CreateDay(); // TODO: Initialize to an appropriate value
            Day expectedDay = CreateDay();

            int startActivity = 5;
            int endActivity = 9;

            Activity defaultActivity1 = new Inside(0, startActivity, targetDay.Map_hq);
            Activity newActivity = new Inside(startActivity, endActivity, targetDay.Map_hq, "eating"); // TODO: Initialize to an appropriate value
            Activity defaultActivity2 = new Inside(endActivity, expectedDay.L_activity.Count - 1, targetDay.Map_hq);

            List<Activity> expected = expectedDay.L_activity;
            int i;
            for (i = 0; i < startActivity; i++) { expected[i] = defaultActivity1; }
            for (i = startActivity; i < endActivity; i++) { expected[i] = newActivity; }
            for (i = endActivity; i < expectedDay.L_activity.Count; i++) { expected[i] = defaultActivity2; }


            targetDay.addActivity(newActivity);

            bool areEqual = compareTwoActList(expected, targetDay.L_activity);
            Assert.IsTrue(areEqual);
        }

        /// <summary>
        ///A test for rmActivity
        ///</summary>
        [TestMethod()]
        public void rmActivityTest()
        {
            Future targetDay = CreateDay(); // TODO: Initialize to an appropriate value  
            Day expectedDay = CreateDay();
            Activity prevActivity = new Inside(5, 9, targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            targetDay.addActivity(prevActivity);
            targetDay.rmActivity(prevActivity);

            bool areEqual = compareTwoActList(expectedDay.L_activity, targetDay.L_activity);
            Assert.IsTrue(areEqual);

        }

        /// <summary>
        ///A test for rmActivity
        ///</summary>
        [TestMethod()]
        public void rmActivityTest1()
        {
            Future targetDay = CreateDay(); // TODO: Initialize to an appropriate value  
            Day expectedDay = CreateDay();
            Activity prevActivity = new Inside(5, 9, targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            targetDay.addActivity(prevActivity);
            int newStart = 7; // TODO: Initialize to an appropriate value
            targetDay.rmActivity(prevActivity, prevActivity.Start, newStart);

            Activity defaultActivity1 = new Inside(0, newStart, targetDay.Map_hq);
            Activity newActivity = new Inside(newStart, prevActivity.End, targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            Activity defaultActivity2 = new Inside(prevActivity.End, expectedDay.L_activity.Count - 1, targetDay.Map_hq);

            List<Activity> expected = expectedDay.L_activity;
            int i;
            for (i = 0; i < newStart; i++) { expected[i] = defaultActivity1; }
            for (i = newStart; i < prevActivity.End; i++) { expected[i] = newActivity; }
            for (i = prevActivity.End; i < expectedDay.L_activity.Count; i++) { expected[i] = defaultActivity2; }

            bool areEqual = compareTwoActList(expected, targetDay.L_activity);
            Assert.IsTrue(areEqual);
        }

        //methode to test several cases
        public bool modifyHoursActivityT(int newStart, int newEnd)
        {
            Future targetDay = CreateDay(); // TODO: Initialize to an appropriate value       
            Activity prevActivity = new Inside(5,9,targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            targetDay.addActivity(prevActivity);
            targetDay.modifyHoursActivity(prevActivity, newStart, newEnd);

            Day expectedDay = CreateDay();
            List<Activity> expected = expectedDay.L_activity;

            Activity defaultActivity1 = new Inside(0, newStart, targetDay.Map_hq);
            Activity newActivity = new Inside(newStart, newEnd, targetDay.Map_hq, "coucou"); // TODO: Initialize to an appropriate value
            Activity defaultActivity2 = new Inside(newEnd, expectedDay.L_activity.Count - 1, targetDay.Map_hq);

            int i;
            for (i = 0; i < newStart; i++) { expected[i] = defaultActivity1; }
            for (i = newStart; i < newEnd; i++) { expected[i] = newActivity; }
            for (i = newEnd; i < expectedDay.L_activity.Count; i++) { expected[i] = defaultActivity2; }

            return compareTwoActList(expected, targetDay.L_activity);
        }

        [TestMethod()]
        public void modifyHoursActivityTest()
        {
            Assert.IsTrue(
                (modifyHoursActivityT(2, 5)) &&
                (modifyHoursActivityT(10, 15)) &&
                (modifyHoursActivityT(5, 7)) &&
                (modifyHoursActivityT(5, 9)) &&
                (modifyHoursActivityT(4, 9)) &&
                (modifyHoursActivityT(4, 10)) &&
                (modifyHoursActivityT(5, 10)));
        }


        public static bool compareTwoActList(List<Activity> l1, List<Activity> l2)
        {
            for (int i = 0; i < l1.Count; i++ )
            {
                //do not test Place because too complicated
                if (!((l1[i].Start == l2[i].Start) &&
                    (l1[i].End == l2[i].End) &&
                    (l1[i].Type.Equals(l2[i].Type))))
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        ///A test for isOutside
        ///</summary>
        [TestMethod()]
        public void isOutsideTest()
        {
            Future target = CreateDay(); // TODO: Initialize to an appropriate value
            Activity act = new Outside(10,15, target.Map_hq, "exploration");
            target.addActivity(act);
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isOutside();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for sortActivityList
        ///</summary>
        [TestMethod()]
        public void sortActivityListTest()
        {
            Day target = CreateDay(); // TODO: Initialize to an appropriate value
            target.sortActivityList();

            Activity sleeping1 = new Inside(0, 7*6, target.Map_hq, "sleeping");
            Activity sleeping2 = new Inside(22*6, 147, target.Map_hq, "sleeping");
            Activity eating1 = new Inside(12*6, 13*6, target.Map_hq, "eating");
            Activity eating2 = new Inside(19*6, 20*6, target.Map_hq, "eating");
            Activity defaultAct1 = new Inside(7*6, 12*6, target.Map_hq, "private");
            Activity defaultAct2 = new Inside(13*6, 19*6, target.Map_hq, "private");
            Activity defaultAct3 = new Inside(20*6, 22*6, target.Map_hq, "private");

            List<Activity> expected = new List<Activity>();

            for (int i = 0; i <= 147; i++) //24*6+4 -1 because no activity at 24:40
            {
                if (i >= 0 && i < 7*6) { expected.Insert(i, sleeping1); }
                else if (i >= 7 * 6 && i < 12 * 6) { expected.Insert(i, defaultAct1); }
                else if (i >= 12 * 6 && i < 13 * 6) { expected.Insert(i, eating1); }
                else if (i >= 13 * 6 && i < 19 * 6) { expected.Insert(i, defaultAct2); }
                else if (i >= 19 * 6 && i < 20 * 6) { expected.Insert(i, eating2); }
                else if (i >= 20 * 6 && i < 22 * 6) { expected.Insert(i, defaultAct3); }
                else if (i >= 22 * 6 && i < 147) { expected.Insert(i, sleeping2); }
                else { expected.Insert(i, defaultAct1); }
            }

            Assert.IsTrue(compareTwoActList(target.L_activity, expected));
        }
    }   
}
