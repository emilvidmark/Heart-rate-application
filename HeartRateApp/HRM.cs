using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateApp
{   //Holds the values for data coming from the watch
    class HRM
    {
        private string Sport;
        private string Date;
        private string StartTime;
        private string Length;
        private int Interval;
        private int MaxHR;
        private int RestHR;
        private int VO2Max;
        private int Weight;
        private int RunningIndex;
        private string HRValues;

        //used when importing hrm files.
        public HRM(string date, string startTime, string length, int interval, int maxHR, int restHR, int VO2Max, int weight, int runningIndex, string HRValues)
        {
            this.Date = date;
            this.StartTime = startTime;
            this.Length = length;
            this.Interval = interval;
            this.MaxHR = maxHR;
            this.RestHR = restHR;
            this.VO2Max = VO2Max;
            this.Weight = weight;
            this.RunningIndex = runningIndex;
            this.HRValues = HRValues;

        }

        //used when loading into form 2
        public HRM(string sport, string date, string startTime, string length, int interval, int maxHR, int restHR, int VO2Max, int weight, int runningIndex, string HRValues)
        {
            this.Sport = sport;
            this.Date = date;
            this.StartTime = startTime;
            this.Length = length;
            this.Interval = interval;
            this.MaxHR = maxHR;
            this.RestHR = restHR;
            this.VO2Max = VO2Max;
            this.Weight = weight;
            this.RunningIndex = runningIndex;
            this.HRValues = HRValues;

        }
        public string GetDate()
        {
            return this.Date;
        }

        public string GetStartTime()
        {
            return this.StartTime;
        }

        public string GetLength()
        {
            return this.Length;
        }

        public int GetInterval()
        {
            return this.Interval;
        }

        public int GetMaxHR()
        {
            return this.MaxHR;
        }

        public int GetRestHR()
        {
            return this.RestHR;
        }

        public int GetVO2Max()
        {
            return this.VO2Max;
        }

        public int GetWeight()
        {
            return this.Weight;
        }

        public int GetRunningIndex()
        {
            return this.RunningIndex;
        }

        public string GetHRValues()
        {
            return this.HRValues;
        }

    }
}
