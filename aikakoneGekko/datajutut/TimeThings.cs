using System;

namespace aikakoneGekko.datajutut
{
    class TimeThings
    {

        /// <summary>
        /// Converts datetime to unix timestamp
        /// </summary>
        /// <param name="time"> Time. </param>
        /// <returns> Returns a timestamp in unix time from a give datetime </returns>
        public static long DateTimetoUnixTimeStamp(DateTime time)
        {
            try
            { 
            DateTimeOffset dto = time;
            long unixtime = dto.ToUnixTimeSeconds();
            return unixtime;
            } catch (ArgumentOutOfRangeException e)
            {
                e = new ArgumentOutOfRangeException(nameof(time), e);
                return 0;
            }
        }
        /// <summary>
        /// Converts unix timestamp to datetime
        /// </summary>
        /// <param name="unixTime"> Unix timestamp </param>
        /// <returns> Returns datetime from an unix timestamp </returns>
        public static DateTime UnixTimeStamptoDateTime(double unixTime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(unixTime).ToLocalTime();
            return dateTime;
        }

    }
}
