using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars
{
    public class Mission
    {
        #region attributes

        private int howmanydays;
        public int HomanyDays { get { return howmanydays; } }

        private bool beginMission;
        public bool BeginMission { get { return beginMission; } }

        private DateTime beginningDateEarth;
        public DateTime BeginningDateEarth
        {
            get { return beginningDateEarth; }
            set
            {
                //if the Mission has not begun
                if (!(beginMission))
                {
                    beginningDateEarth = value;
                    updateEnd();
                };
            }
        }

        private DateTime endingDateEarth;
        public DateTime EndingDateEatrh { get { return endingDateEarth; } }

        private DateTime lastUpDateEarth;
        public DateTime LastUpdateEarth { get { return lastUpDateEarth; } }

        private int[] click_hq;
        public int[] click_Hq { get { return click_hq; } }

        private Place map_hq;
        public Place map_Hq { get { return map_hq; } }

        private List<String> l_genericActivity;
        public List<String> L_genericActivity { get { return l_genericActivity; } } //get general activity from XML

        private List<Day> l_day;
        public List<Day> L_day { get { return l_day; } }

        private List<Astronaut> l_astronaut;
        public List<Astronaut> L_astronaut { get { return l_astronaut; } }

        private List<Place> l_place;
        public List<Place> L_place { get { return l_place; } }

        # endregion

        #region constructor

        public Mission(int _howmanydays, int _hq_x = 700, int _hq_y = 1000)
        {
            howmanydays = _howmanydays;
            beginMission = false;
            l_astronaut = new List<Astronaut>();
            click_hq = new int[] { _hq_x, _hq_y };
            map_hq = new Place(0.0, 0.0, "HQ", click_hq);
            l_day = new List<Day>();
            for (int i = 0; i < howmanydays; i++)
            {
                l_day.Insert(i, new Future(i, map_hq));
            }
            //generate l_activity from XML
            l_place = new List<Place>();
            lastUpDateEarth = DateTime.Now;
        }
        #endregion

        #region methodes

        #region astronaut management
        public void add_astronaut(Astronaut astro)
        {
            DateTime now = DateTime.Now;
            if (beginningDateEarth < now) { l_astronaut.Add(astro); }
        }

        public void rm_astronaut(Astronaut astro)
        {
            DateTime now = DateTime.Now;
            if (l_astronaut.Contains(astro) && beginningDateEarth < now) l_astronaut.Remove(astro);
        }
        #endregion

        #region general activities management
        public void addActivity(string act)
        {
            l_genericActivity.Add(act);
            // write it on the XML doc
        }
        #endregion

        #region get places
        public List<Place> getPlaces(Day start, Day end)
        {
            List<Place> lp = new List<Place>();
            for (int i = start.Number; i <= end.Number; i++)
            {
                if (l_day[i].isOutside())
                {
                    foreach (Activity act in l_day[i].L_activity) { if (act is Outside) { lp.Add(act.Place); } }
                }
            }
            return lp;
        }
        public List<Place> getPlaces(Day start) { return getPlaces(start, start); }
        public List<Place> getPlaces(int start, int end) { return getPlaces(getMarsDay(start), getMarsDay(end)); }
        public List<Place> getPlaces(int start) { return getPlaces(start, start); }
        public List<Place> getPlaces() { return getPlaces(0, howmanydays); } //from the beginning until the end
        #endregion

        #region conversion methodes earth/mars
        public int[] convertEarthDateInMissionDay(DateTime date)
        {
            //return the number of the day and minutes id (from 0 to 147) of the mission of a given date
            int[] dayMin = new int[2];

            TimeSpan ts = date - beginningDateEarth;
            int minDif = (int)ts.TotalMinutes;

            //only works if the given date is during the mission 
            if ((DateTime.Compare(date, beginningDateEarth) >= 0) && DateTime.Compare(date, endingDateEarth) <= 0)
            {
                dayMin[0] = (minDif / 10) / 148;
                dayMin[1] = (minDif / 10) % 148;
            }
            else
            {
                //error message
            }

            return dayMin;
        }

        public int[] convertEarthDateInMissionDay() { return convertEarthDateInMissionDay(DateTime.Now); }

        public DateTime convertMarsDayInEarthDate(int[] marsDayMinNumber)
        {
            if (beginningDateEarth != DateTime.MinValue)
            {
                //make the same integrating minutes
                int totalMin = (marsDayMinNumber[0] * 148 + marsDayMinNumber[1]);
                int[] nbDayEarth = { totalMin / 144, totalMin % 144 };
                DateTime convert = beginningDateEarth.AddDays(nbDayEarth[0] + (nbDayEarth[1] / 144)); //days
                convert = convert.AddMinutes((nbDayEarth[1] % 144)); //hours
                return convert;
            }
            return DateTime.Now;
        }

        public DateTime convertMarsDayInEarthDate(int marsDayNumber) { return convertMarsDayInEarthDate(new int[] { marsDayNumber, 0 }); }

        public DateTime convertMarsDayInEarthDate(Day marsDay) { return convertMarsDayInEarthDate(marsDay.Number); }

        //method that return a Mars Day from its id number
        public Day getMarsDay(int numDay) { if (numDay >= 0 && numDay <= howmanydays) { return l_day[numDay]; } return null; }
        //with no parameters, it returns the present day
        public Day getMarsDay()
        {
            //foreach but there is only one
            foreach (Day d in l_day)
            {
                if (d is Present) { return d; }
            }
            return null;
        }

        #endregion

        #region start a mission

        public void startMission()
        {
            //the mission can has been programmed to start at a certain date but 
            //it has to be launched to really start
            //in that case, it updates days status

            //if beginmissionstart is not defined, it takes the current hour as value 
            if (!(beginMission) && (beginningDateEarth == DateTime.MinValue))
            {
                beginningDateEarth = DateTime.Now;
                updateEnd();
            }

            //we can't launch the mission if the beginning date has been programmed to be later
            if (!(beginMission) && (DateTime.Now >= beginningDateEarth))
            {
                beginMission = true;
                updateDays();
            }
        }

        #endregion

        #region day status and updates

        public void updateDays()
        {
            lastUpDateEarth = DateTime.Now;
            int currentMarsDay = convertEarthDateInMissionDay(lastUpDateEarth)[0];
            for (int i = 0; i < currentMarsDay; i++)
            {
                changeDayStatus(l_day[i], "past");
            }
            changeDayStatus(l_day[currentMarsDay], "present");
        }

        public void changeDayStatus(Day d, string to)
        {
            Day newDay = d; // in case d is already converted in to
            switch (to)
            {
                case "past":
                    if (!(d is Past)) { newDay = new Past(d.Number, d.Map_hq); }
                    break;
                case "present":
                    if (!(d is Present)) { newDay = new Present(d.Number, d.Map_hq); }
                    break;
                default: //case "future":
                    if (!(d is Future)) { newDay = new Future(d.Number, d.Map_hq); }
                    break;
            }
            l_day[d.Number] = newDay;
            newDay.L_activity = d.L_activity;
            newDay.Report = d.Report;
        }
        #endregion

        #region intern methodes
        private void updateEnd()
        {
            endingDateEarth = convertMarsDayInEarthDate(howmanydays);
        }

        #endregion

        #endregion
    }
}