using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Telefonai_L2
{
    public sealed class PriceList
    {
        private sealed class PriceNode
        {
            public Price Data { get; set; }
            public PriceNode Address { get; set; }
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public PriceNode()
            {

            }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="data"> All data about user</param>
            /// <param name="address"> Object address </param>
            public PriceNode(Price data, PriceNode address)
            {
                Data = data;
                Address = address;
            }
        }

        private PriceNode Start;
        private PriceNode End;
        private PriceNode Arrow;
        public int count = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public PriceList()
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
            Arrow = Arrow.Address;
        }
        /// <summary>
        /// Gets data
        /// </summary>
        /// <returns> User data </returns>
        public Price GetData()
        {
            return Arrow.Data;
        }
        /// <summary>
        /// Add data
        /// </summary>
        /// <param name="user"></param>
        public void AddData(Price price)
        {
            if (Start == null)
            {
                Start = new PriceNode(price, null);
                End = Start;
            }
            else
            {
                End.Address = new PriceNode(price, null);
                End = End.Address;
            }
            count++;
        }
    }
}