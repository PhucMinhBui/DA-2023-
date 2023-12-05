using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public  class UserData
    {
        private static List<UserData> users = new List<UserData>();

      

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserData() { }

        public UserData(string email, string userName, string password)
        {
            this.Email = email;
            this.Username = userName;
            this.Password = password;
        }
        public UserData( string userName, string password)
        {
            this.Username = userName;
            this.Password = password;
        }

        public static List<UserData> getAllUser()
        {
            return users;
        }
        public void saveUserData()
        {

        }
        public void readUserData()
        {

        }
        //public string Username { get; set; }
        //public string Password { get; set; }

        //public UserData(string username, string password)
        //{
        //    Username = username;
        //    Password = password;
        //}
    }
}
