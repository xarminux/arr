using System;

namespace Telefonai_L2
{
    public class User
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CityTo { get; set; }
        public DateTime Start { get; set; }
        public int CallDuration { get; set; }
        /// <summary>
        /// User Data
        /// </summary>
        /// <param name="lastName"> User last name</param>
        /// <param name="name"> User name </param>
        /// <param name="phoneNumber"> user phone number</param>
        /// <param name="cityTo"> Calling in to city</param>
        /// <param name="start"> When start call </param>
        /// <param name="callDuration"> User call duration</param>
        public User(string lastName, string name, string phoneNumber, string cityTo, DateTime start, int callDuration)
        {
            LastName = lastName;
            Name = name;
            PhoneNumber = phoneNumber;
            CityTo = cityTo;
            Start = start;
            CallDuration = callDuration;
        }
        /// <summary>
        /// Override string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("| {0, 10} | {1, 8} | {2, 13} | {3, 8} | {4, 3}:{5,-3} | {6, 6} | ", LastName, Name, PhoneNumber, CityTo, Convert.ToString(Start.Hour), Convert.ToString(Start.Minute), Convert.ToString(CallDuration));
        }
        /// <summary>
        /// Override operator > for sorting
        /// </summary>
        /// <param name="lhs"> left User</param>
        /// <param name="rhs"> right user</param>
        /// <returns></returns>
        static public bool operator >(User lhs, User rhs)
        {
            if (String.Compare(lhs.LastName, rhs.LastName) == 0)
            {
                return String.Compare(lhs.Name, rhs.Name) > 0;
            }
            else
            {
                return String.Compare(lhs.Name, rhs.Name) > 0;
            }
        }
        /// <summary>
        /// Override operator < 
        /// </summary>
        /// <param name="lhs"> left User</param>
        /// <param name="rhs"> right user</param>
        /// <returns></returns>
        static public bool operator <(User lhs, User rhs)
        {
            if (String.Compare(lhs.LastName, rhs.LastName) == 0)
            {
                return String.Compare(lhs.Name, rhs.Name) < 0;
            }
            else
            {
                return String.Compare(lhs.Name, rhs.Name) < 0;
            }
        }


    }
}