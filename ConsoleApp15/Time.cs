using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public static Time operator +(Time t1, Time t2)
        {
            int seconds = t1.Seconds + t2.Seconds;
            int minutes = t1.Minutes + t2.Minutes;
            int hours = t1.Hours + t2.Hours;

            if (seconds >= 60)
            {
                seconds -= 60;
                minutes++;
            }

            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            return new Time(hours, minutes, seconds);
        }

        public static Time operator -(Time t1, Time t2)
        {
            int seconds = t1.Seconds - t2.Seconds;
            int minutes = t1.Minutes - t2.Minutes;
            int hours = t1.Hours - t2.Hours;

            if (seconds < 0)
            {
                seconds += 60;
                minutes--;
            }

            if (minutes < 0)
            {
                minutes += 60;
                hours--;
            }

            return new Time(hours, minutes, seconds);
        }

        public static bool operator >(Time t1, Time t2)
        {
            if (t1.Hours > t2.Hours)
                return true;
            if (t1.Hours == t2.Hours && t1.Minutes > t2.Minutes)
                return true;
            if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds > t2.Seconds)
                return true;

            return false;
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hours < t2.Hours)
                return true;
            if (t1.Hours == t2.Hours && t1.Minutes < t2.Minutes)
                return true;
            if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds < t2.Seconds)
                return true;

            return false;
        }

        public static Time operator ++(Time t)
        {
            return t + new Time(0, 0, 1);
        }

        public static Time operator --(Time t)
        {
            return t - new Time(0, 0, 1);
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

    }
}
