using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MyClock : IClock
    {
        private DateTime dt;

        public MyClock()
        {
            this.dt = DateTime.Now;
        }

        //public MyClock(DateTime dt)
        //{
        //    this.dt = dt;
        //}

        public long Ticks => dt.Ticks;

        public DateTime Date => dt.Date;

        public int Month => dt.Month;

        public int Minute => dt.Minute;

        public int Millisecond => dt.Millisecond;

        public DateTimeKind Kind => dt.Kind;

        public int Hour => dt.Hour;

        public int DayOfYear => dt.DayOfYear;

        public DayOfWeek DayOfWeek => dt.DayOfWeek;

        public int Day => dt.Day;

        public int Second => dt.Second;

        public TimeSpan TimeOfDay => throw new NotImplementedException();

        public int Year => throw new NotImplementedException();

        public DateTime Add(TimeSpan value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddDays(double value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddHours(double value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddMilliseconds(double value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddMinutes(double value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddMonths(int months)
        {
            throw new NotImplementedException();
        }

        public DateTime AddSeconds(double value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddTicks(long value)
        {
            throw new NotImplementedException();
        }

        public DateTime AddYears(int value)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object value)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(DateTime value)
        {
            throw new NotImplementedException();
        }

        public bool Equals(DateTime value)
        {
            throw new NotImplementedException();
        }

        public string[] GetDateTimeFormats()
        {
            throw new NotImplementedException();
        }

        public string[] GetDateTimeFormats(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string[] GetDateTimeFormats(char format, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string[] GetDateTimeFormats(char format)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool IsDaylightSavingTime()
        {
            throw new NotImplementedException();
        }

        public TimeSpan Subtract(DateTime value)
        {
            throw new NotImplementedException();
        }

        public DateTime Subtract(TimeSpan value)
        {
            throw new NotImplementedException();
        }

        public long ToBinary()
        {
            throw new NotImplementedException();
        }

        public long ToFileTime()
        {
            throw new NotImplementedException();
        }

        public long ToFileTimeUtc()
        {
            throw new NotImplementedException();
        }

        public DateTime ToLocalTime()
        {
            throw new NotImplementedException();
        }

        public string ToLongDateString()
        {
            throw new NotImplementedException();
        }

        public string ToLongTimeString()
        {
            throw new NotImplementedException();
        }

        public double ToOADate()
        {
            throw new NotImplementedException();
        }

        public string ToShortDateString()
        {
            throw new NotImplementedException();
        }

        public string ToShortTimeString()
        {
            throw new NotImplementedException();
        }

        public string ToString(string format, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string format)
        {
            throw new NotImplementedException();
        }

        public DateTime ToUniversalTime()
        {
            throw new NotImplementedException();
        }
    }
}
