using Mars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for MissionTest and is intended
    ///to contain all MissionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MissionTest
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


        /// <summary>
        ///A test for convertEarthDateInMissionDay
        ///</summary>
        [TestMethod()]
        public void convertEarthDateInMissionDayTest()
        {
            int _howmanydays = 500; // TODO: Initialize to an appropriate value
            int _hq_x = 700; // TODO: Initialize to an appropriate value
            int _hq_y = 1000; // TODO: Initialize to an appropriate value
            Mission target = new Mission(_howmanydays, _hq_x, _hq_y); // TODO: Initialize to an appropriate value
            DateTime start = new DateTime(2015, 11, 21);
            target.startMission();
            DateTime date = new DateTime(2015,11,23); // TODO: Initialize to an appropriate value
            int[] actual = target.convertEarthDateInMissionDay(date);
            int[] expected = {1,140}; // TODO: Initialize to an appropriate value
            actual = target.convertEarthDateInMissionDay(date);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for startMission
        ///</summary>
        [TestMethod()]
        public void startMissionTest()
        {
            int _howmanydays = 500; // TODO: Initialize to an appropriate value
            int _hq_x = 700; // TODO: Initialize to an appropriate value
            int _hq_y = 1000; // TODO: Initialize to an appropriate value
            Mission target = new Mission(_howmanydays, _hq_x, _hq_y); // TODO: Initialize to an appropriate value
            DateTime CurrentEarthDate = new DateTime(2015,11,23); // TODO: Initialize to an appropriate value
            target.startMission();
            DateTime expected = CurrentEarthDate;
            DateTime actual = target.BeginningDateEarth;
            if (target.BeginMission) Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for changeDayStatus
        ///</summary>
        [TestMethod()]
        public void changeDayStatusTest()
        {
            int _howmanydays = 500; // TODO: Initialize to an appropriate value
            int _hq_x = 700; // TODO: Initialize to an appropriate value
            int _hq_y = 1000; // TODO: Initialize to an appropriate value
            Mission target = new Mission(_howmanydays, _hq_x, _hq_y); // TODO: Initialize to an appropriate value
            int nbJour = 5;
            target.startMission();
            List<Day> expected = new List<Day>();

            int i;
            for (i = 0; i < nbJour; i++) { expected.Insert(i,new Present(i,target.map_Hq)); }
            for (i = nbJour; i < _howmanydays; i++) { expected.Insert(i, new Future(i, target.map_Hq)); }

            bool same = true;
            int j=0;
            while (same && (j < _howmanydays))
            {
                if (!(target.L_day[j].Number == expected[j].Number)) { same = false; }
                j++;
            }

            Assert.IsTrue(same);
        }
    }
}
