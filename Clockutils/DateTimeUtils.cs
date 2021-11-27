using System;
using System.Collections.Generic;
using System.Text;

namespace Clockutils
{
    public static class DateTimeUtils
    {
        public static int getDay()
        {
            return DateTime.Now.Day;
        }

        public static int getMonth()
        {
            return DateTime.Now.Month;
        }

        public static int getYear()
        {
            return DateTime.Now.Year;

        }

        public static int getHour()
        {
            return DateTime.Now.Hour;
        }

        public static int getMinute()
        {
            return DateTime.Now.Minute;
        }

        public static int getSecond()
        {
            return DateTime.Now.Second;
        }
        
        //bin
        public static string getDaybin()
        {
            return Convert.ToString(getDay(), 2);
        }

        public static string getMonthbin()
        {
            return Convert.ToString(getMonth(), 2);
        }
        public static string getYearbin()
        {
            return Convert.ToString(getYear(), 2);
        }

        public static string getHourbin()
        {
            return Convert.ToString(getHour(), 2);
        }

        public static string getMinutebin()
        {
            return Convert.ToString(getMinute(), 2);
        }

        public static string getSecondbin()
        {
            return Convert.ToString(getSecond(), 2);
        }

        //octal
        public static string getDayoct()
        {
            return Convert.ToString(getDay(), 8);
        }

        public static string getMonthoct()
        {
            return Convert.ToString(getMonth(), 8);
        }
        public static string getYearoct()
        {
            return Convert.ToString(getYear(), 8);
        }

        public static string getHouroct()
        {
            return Convert.ToString(getHour(), 8);
        }

        public static string getMinuteoct()
        {
            return Convert.ToString(getMinute(), 8);
        }

        public static string getSecondoct()
        {
            return Convert.ToString(getSecond(), 8);
        }

        //hex
        public static string getDayhex()
        {
            return Convert.ToString(getDay(), 16);
        }

        public static string getMonthhex()
        {
            return Convert.ToString(getMonth(), 16);
        }
        public static string getYearhex()
        {
            return Convert.ToString(getYear(), 16);
        }

        public static string getHourhex()
        {
            return Convert.ToString(getHour(), 16);
        }

        public static string getMinutehex()
        {
            return Convert.ToString(getMinute(), 16);
        }

        public static string getSecondhex()
        {
            return Convert.ToString(getSecond(), 16);
        }
    }
}
