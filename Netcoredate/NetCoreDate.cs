using System;
namespace Netcoredate
{
    public static class Netcoredate
    {


        public static bool isBetween(this DateTime source, DateTime begin, DateTime end)
        {

            
            return true;
        }

        public static string inWords(this DateTime date)
        {
            return date.ToShortDateString();
        }



        public static DateTime Tomorrow(this DateTime date)
        {
            return date.AddDays(1);
        }

    }
}