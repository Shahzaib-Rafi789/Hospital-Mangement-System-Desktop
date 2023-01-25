using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public Date(string date)
        {
            string[] SplittedRecord = date.Split('/');
            Day = int.Parse(SplittedRecord[1]);
            Month = int.Parse(SplittedRecord[0]);
            Year = int.Parse(SplittedRecord[2]);
        }

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public string ConvertToString()
        {
            return Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
        }

        public void AssignValue(string Date)
        {
            string[] SplittedRecord = Date.Split('/');
            Day = int.Parse(SplittedRecord[0]);
            Month = int.Parse(SplittedRecord[1]);
            Year = int.Parse(SplittedRecord[2]);
        }
    }
}
