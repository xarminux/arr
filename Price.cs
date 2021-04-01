using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonai_L2
{
    public class Price
    {
        public string City { get; set; }
        public double ConnectionPrice { get; set; }
        public double DayPrice { get; set; }
        public double NightPrice { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="city"> City </param>
        /// <param name="connectionPrice"> connection price</param>
        /// <param name="dayPrice"> daily rate</param>
        /// <param name="nightPrice"> night rate </param>
        public Price(string city, double connectionPrice, double dayPrice, double nightPrice)
        {
            City = city;
            ConnectionPrice = connectionPrice;
            DayPrice = dayPrice;
            NightPrice = nightPrice;
        }
        /// <summary>
        /// override string
        /// </summary>
        /// <returns> string value</returns>
        public override string ToString()
        {
            return String.Format("| {0, 8} | {1, -15} | {2, -15} | {3, -17} |", City, ConnectionPrice, DayPrice, NightPrice);
        }
    }
}