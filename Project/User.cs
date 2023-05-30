using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class User
    {
        public int userid { get; set; }
        public string fullname { get; set; }
        public DateTime bdate { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User(string fullname, DateTime bdate, string address, string username, string password)
        {
            this.userid = 0;
            this.fullname = fullname;
            this.bdate = bdate;
            this.address = address;
            this.username = username;
            this.password = password;
        }

        public User(int userid, string fullname, DateTime bdate, string address, string username, string password)
        {
            this.userid = userid;
            this.fullname = fullname;
            this.bdate = bdate;
            this.address = address;
            this.username = username;
            this.password = password;
        }
    }
}
