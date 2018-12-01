using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IClock
    {
        //
        // Summary:
        //     Gets the number of ticks that represent the date and time of this instance.
        //
        // Returns:
        //     The number of ticks that represent the date and time of this instance. The value
        //     is between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.
        long Ticks { get; }
        //
        // Summary:
        //     Gets the date component of this instance.
        //
        // Returns:
        //     A new object with the same date as this instance, and the time value set to 12:00:00
        //     midnight (00:00:00).
        DateTime Date { get; }
        //
        // Summary:
        //     Gets the month component of the date represented by this instance.
        //
        // Returns:
        //     The month component, expressed as a value between 1 and 12.
        int Month { get; }
        //
        // Summary:
        //     Gets the minute component of the date represented by this instance.
        //
        // Returns:
        //     The minute component, expressed as a value between 0 and 59.
        int Minute { get; }
        //
        // Summary:
        //     Gets the milliseconds component of the date represented by this instance.
        //
        // Returns:
        //     The milliseconds component, expressed as a value between 0 and 999.
        int Millisecond { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the time represented by this instance is
        //     based on local time, Coordinated Universal Time (UTC), or neither.
        //
        // Returns:
        //     One of the enumeration values that indicates what the current time represents.
        //     The default is System.DateTimeKind.Unspecified.
        DateTimeKind Kind { get; }
        //
        // Summary:
        //     Gets the hour component of the date represented by this instance.
        //
        // Returns:
        //     The hour component, expressed as a value between 0 and 23.
        int Hour { get; }
        //
        // Summary:
        //     Gets the day of the year represented by this instance.
        //
        // Returns:
        //     The day of the year, expressed as a value between 1 and 366.
        int DayOfYear { get; }
        //
        // Summary:
        //     Gets the day of the week represented by this instance.
        //
        // Returns:
        //     An enumerated constant that indicates the day of the week of this System.DateTime
        //     value.
        DayOfWeek DayOfWeek { get; }
        //
        // Summary:
        //     Gets the day of the month represented by this instance.
        //
        // Returns:
        //     The day component, expressed as a value between 1 and 31.
        int Day { get; }
        //
        // Summary:
        //     Gets the seconds component of the date represented by this instance.
        //
        // Returns:
        //     The seconds component, expressed as a value between 0 and 59.
        int Second { get; }
        //
        // Summary:
        //     Gets the time of day for this instance.
        //
        // Returns:
        //     A time interval that represents the fraction of the day that has elapsed since
        //     midnight.
        TimeSpan TimeOfDay { get; }
        //
        // Summary:
        //     Gets the year component of the date represented by this instance.
        //
        // Returns:
        //     The year, between 1 and 9999.
        int Year { get; }

        
        DateTime Add(TimeSpan value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of days to the value
        //     of this instance.
        //
        // Parameters:
        //   value:
        //     A number of whole and fractional days. The value parameter can be negative or
        //     positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of days represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddDays(double value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of hours to the
        //     value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of whole and fractional hours. The value parameter can be negative or
        //     positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of hours represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddHours(double value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of milliseconds
        //     to the value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of whole and fractional milliseconds. The value parameter can be negative
        //     or positive. Note that this value is rounded to the nearest integer.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of milliseconds represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddMilliseconds(double value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of minutes to the
        //     value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of whole and fractional minutes. The value parameter can be negative
        //     or positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of minutes represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddMinutes(double value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of months to the
        //     value of this instance.
        //
        // Parameters:
        //   months:
        //     A number of months. The months parameter can be negative or positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and months.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.-or- months is less than -120,000 or greater than
        //     120,000.
        DateTime AddMonths(int months);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of seconds to the
        //     value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of whole and fractional seconds. The value parameter can be negative
        //     or positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of seconds represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddSeconds(double value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of ticks to the
        //     value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of 100-nanosecond ticks. The value parameter can be positive or negative.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the time represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting System.DateTime is less than System.DateTime.MinValue or greater
        //     than System.DateTime.MaxValue.
        DateTime AddTicks(long value);
        //
        // Summary:
        //     Returns a new System.DateTime that adds the specified number of years to the
        //     value of this instance.
        //
        // Parameters:
        //   value:
        //     A number of years. The value parameter can be negative or positive.
        //
        // Returns:
        //     An object whose value is the sum of the date and time represented by this instance
        //     and the number of years represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     value or the resulting System.DateTime is less than System.DateTime.MinValue
        //     or greater than System.DateTime.MaxValue.
        DateTime AddYears(int value);
        //
        // Summary:
        //     Compares the value of this instance to a specified object that contains a specified
        //     System.DateTime value, and returns an integer that indicates whether this instance
        //     is earlier than, the same as, or later than the specified System.DateTime value.
        //
        // Parameters:
        //   value:
        //     A boxed object to compare, or null.
        //
        // Returns:
        //     A signed number indicating the relative values of this instance and value.Value
        //     Description Less than zero This instance is earlier than value. Zero This instance
        //     is the same as value. Greater than zero This instance is later than value, or
        //     value is null.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     value is not a System.DateTime.
        int CompareTo(object value);
        //
        // Summary:
        //     Compares the value of this instance to a specified System.DateTime value and
        //     returns an integer that indicates whether this instance is earlier than, the
        //     same as, or later than the specified System.DateTime value.
        //
        // Parameters:
        //   value:
        //     The object to compare to the current instance.
        //
        // Returns:
        //     A signed number indicating the relative values of this instance and the value
        //     parameter.Value Description Less than zero This instance is earlier than value.
        //     Zero This instance is the same as value. Greater than zero This instance is later
        //     than value.
        int CompareTo(DateTime value);
        //
        // Summary:
        //     Returns a value indicating whether the value of this instance is equal to the
        //     value of the specified System.DateTime instance.
        //
        // Parameters:
        //   value:
        //     The object to compare to this instance.
        //
        // Returns:
        //     true if the value parameter equals the value of this instance; otherwise, false.
        bool Equals(DateTime value);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the standard date and time format specifiers.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        string[] GetDateTimeFormats();
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the standard date and time format specifiers and the specified culture-specific
        //     formatting information.
        //
        // Parameters:
        //   provider:
        //     An object that supplies culture-specific formatting information about this instance.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        string[] GetDateTimeFormats(IFormatProvider provider);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the specified standard date and time format specifier and culture-specific
        //     formatting information.
        //
        // Parameters:
        //   format:
        //     A date and time format string (see Remarks).
        //
        //   provider:
        //     An object that supplies culture-specific formatting information about this instance.
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with one of the standard date and time format specifiers.
        //
        // Exceptions:
        //   T:System.FormatException:
        //     format is not a valid standard date and time format specifier character.
        string[] GetDateTimeFormats(char format, IFormatProvider provider);
        //
        // Summary:
        //     Converts the value of this instance to all the string representations supported
        //     by the specified standard date and time format specifier.
        //
        // Parameters:
        //   format:
        //     A standard date and time format string (see Remarks).
        //
        // Returns:
        //     A string array where each element is the representation of the value of this
        //     instance formatted with the format standard date and time format specifier.
        //
        // Exceptions:
        //   T:System.FormatException:
        //     format is not a valid standard date and time format specifier character.
        string[] GetDateTimeFormats(char format);
        //
        // Summary:
        //     Returns the System.TypeCode for value type System.DateTime.
        //
        // Returns:
        //     The enumerated constant, System.TypeCode.DateTime.
        TypeCode GetTypeCode();
        //
        // Summary:
        //     Indicates whether this instance of System.DateTime is within the daylight saving
        //     time range for the current time zone.
        //
        // Returns:
        //     true if the value of the System.DateTime.Kind property is System.DateTimeKind.Local
        //     or System.DateTimeKind.Unspecified and the value of this instance of System.DateTime
        //     is within the daylight saving time range for the local time zone; false if System.DateTime.Kind
        //     is System.DateTimeKind.Utc.
        bool IsDaylightSavingTime();
        //
        // Summary:
        //     Subtracts the specified date and time from this instance.
        //
        // Parameters:
        //   value:
        //     The date and time value to subtract.
        //
        // Returns:
        //     A time interval that is equal to the date and time represented by this instance
        //     minus the date and time represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The result is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        TimeSpan Subtract(DateTime value);
        //
        // Summary:
        //     Subtracts the specified duration from this instance.
        //
        // Parameters:
        //   value:
        //     The time interval to subtract.
        //
        // Returns:
        //     An object that is equal to the date and time represented by this instance minus
        //     the time interval represented by value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The result is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        DateTime Subtract(TimeSpan value);
        //
        // Summary:
        //     Serializes the current System.DateTime object to a 64-bit binary value that subsequently
        //     can be used to recreate the System.DateTime object.
        //
        // Returns:
        //     A 64-bit signed integer that encodes the System.DateTime.Kind and System.DateTime.Ticks
        //     properties.
        long ToBinary();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to a Windows file time.
        //
        // Returns:
        //     The value of the current System.DateTime object expressed as a Windows file time.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting file time would represent a date and time before 12:00 midnight
        //     January 1, 1601 C.E. UTC.
        long ToFileTime();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to a Windows file time.
        //
        // Returns:
        //     The value of the current System.DateTime object expressed as a Windows file time.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The resulting file time would represent a date and time before 12:00 midnight
        //     January 1, 1601 C.E. UTC.
        long ToFileTimeUtc();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to local time.
        //
        // Returns:
        //     An object whose System.DateTime.Kind property is System.DateTimeKind.Local, and
        //     whose value is the local time equivalent to the value of the current System.DateTime
        //     object, or System.DateTime.MaxValue if the converted value is too large to be
        //     represented by a System.DateTime object, or System.DateTime.MinValue if the converted
        //     value is too small to be represented as a System.DateTime object.
        DateTime ToLocalTime();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent long
        //     date string representation.
        //
        // Returns:
        //     A string that contains the long date string representation of the current System.DateTime
        //     object.
        string ToLongDateString();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent long
        //     time string representation.
        //
        // Returns:
        //     A string that contains the long time string representation of the current System.DateTime
        //     object.
        string ToLongTimeString();
        //
        // Summary:
        //     Converts the value of this instance to the equivalent OLE Automation date.
        //
        // Returns:
        //     A double-precision floating-point number that contains an OLE Automation date
        //     equivalent to the value of this instance.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     The value of this instance cannot be represented as an OLE Automation Date.
        double ToOADate();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent short
        //     date string representation.
        //
        // Returns:
        //     A string that contains the short date string representation of the current System.DateTime
        //     object.
        string ToShortDateString();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent short
        //     time string representation.
        //
        // Returns:
        //     A string that contains the short time string representation of the current System.DateTime
        //     object.
        string ToShortTimeString();
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent string
        //     representation using the specified format and culture-specific format information.
        //
        // Parameters:
        //   format:
        //     A standard or custom date and time format string.
        //
        //   provider:
        //     An object that supplies culture-specific formatting information.
        //
        // Returns:
        //     A string representation of value of the current System.DateTime object as specified
        //     by format and provider.
        //
        // Exceptions:
        //   T:System.FormatException:
        //     The length of format is 1, and it is not one of the format specifier characters
        //     defined for System.Globalization.DateTimeFormatInfo.-or- format does not contain
        //     a valid custom format pattern.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The date and time is outside the range of dates supported by the calendar used
        //     by provider.
        string ToString(string format, IFormatProvider provider);
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent string
        //     representation using the specified culture-specific format information.
        //
        // Parameters:
        //   provider:
        //     An object that supplies culture-specific formatting information.
        //
        // Returns:
        //     A string representation of value of the current System.DateTime object as specified
        //     by provider.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The date and time is outside the range of dates supported by the calendar used
        //     by provider.
        string ToString(IFormatProvider provider);
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent string
        //     representation using the specified format and the formatting conventions of the
        //     current culture.
        //
        // Parameters:
        //   format:
        //     A standard or custom date and time format string (see Remarks).
        //
        // Returns:
        //     A string representation of value of the current System.DateTime object as specified
        //     by format.
        //
        // Exceptions:
        //   T:System.FormatException:
        //     The length of format is 1, and it is not one of the format specifier characters
        //     defined for System.Globalization.DateTimeFormatInfo.-or- format does not contain
        //     a valid custom format pattern.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The date and time is outside the range of dates supported by the calendar used
        //     by the current culture.
        string ToString(string format);
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to its equivalent string
        //     representation using the formatting conventions of the current culture.
        
        //
        // Summary:
        //     Converts the value of the current System.DateTime object to Coordinated Universal
        //     Time (UTC).
        //
        // Returns:
        //     An object whose System.DateTime.Kind property is System.DateTimeKind.Utc, and
        //     whose value is the UTC equivalent to the value of the current System.DateTime
        //     object, or System.DateTime.MaxValue if the converted value is too large to be
        //     represented by a System.DateTime object, or System.DateTime.MinValue if the converted
        //     value is too small to be represented by a System.DateTime object.
        DateTime ToUniversalTime();
    }
}
