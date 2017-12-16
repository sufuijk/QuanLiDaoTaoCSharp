using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDaoTao
{
    class Account
    {
        private Account()
        {

        }
        // using singleton 
        private static Account user = null;
        

        private string username;
        private string grant;
        private string detail;
        private string passwd;

        public static Account User
        {
            get
            {
                if(user == null)
                {
                    user = new Account();
                }
                return user;
            }
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setGrant(string grant)
        {
            this.grant = grant;
        }
        public void setPasswd(string passwd)
        {
            this.passwd = passwd;
        }
        public void setDetail(string detail)
        {
            this.detail = detail;
        }
        public string getPassword()
        {
            return this.passwd;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getGrant()
        {
            return this.grant;

        }
        public string getDetail()
        {
            return this.detail;
        }

    }
}
