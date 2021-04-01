using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonai_L2
{
    public sealed class UserList
    {
        private sealed class UserNode
        {
            public User Data { get; set; }
            public UserNode Address { get; set; }
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public UserNode()
            {

            }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="data"> All data about user</param>
            /// <param name="address"> Object address </param>
            public UserNode(User data, UserNode address)
            {
                Data = data;
                Address = address;

            }
            public UserNode GetAddres()
            {
                return Address;
            }
        }

        private UserNode Start; //Start address
        private UserNode End; //End address
        private UserNode Arrow; //arrow for address
        public int count = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public UserList()
        {
            Start = null;
            End = null;
            Arrow = Start;
        }
        /// <summary>
        /// set arrow value like start address
        /// </summary>
        public void SetStart()
        {
            Arrow = Start;
        }
        /// <summary>
        /// Check are the list are empty
        /// </summary>
        /// <returns> bool value </returns>
        public bool Empty()
        {
            return Arrow == null;
        }
        /// <summary>
        /// Set arrow to the next address
        /// </summary>
        /// <returns></returns>
        public void Next()
        {
            Arrow = Arrow.GetAddres();
            
        }
        /// <summary>
        /// Gets data
        /// </summary>
        /// <returns> User data </returns>
        public User GetData()
        {
            return Arrow.Data;
        }
        /// <summary>
        /// Add data
        /// </summary>
        /// <param name="user"></param>
        public void AddData(User user)
        {
            if(Start == null)
            {
                Start = new UserNode(user, null);
                End = Start;
            }
            else
            {
                End.Address = new UserNode(user, null);
                End = End.Address;
            }
            count++;
        }
        /// <summary>
        /// Sorts user list
        /// </summary>
        public void Sort()
        {
            for (UserNode d1 = Start; d1 != null; d1 = d1.Address)
            {
                UserNode maxv = d1;
                for (UserNode d2 = d1; d2 != null; d2 = d2.Address)
                    if (d2.Data < maxv.Data)
                        maxv = d2;
                User a = d1.Data;
                d1.Data = maxv.Data;
                maxv.Data = a;
            }
        }


    }
}