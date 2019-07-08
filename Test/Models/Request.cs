using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Request
    {
        public int RequestId
        {
            get;
            set;
        }
        public int CarId
        {
            get;
            set;
        }
        public int ClientId
        {
            get;
            set;
        }
        public int TotalCost
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
    }
}