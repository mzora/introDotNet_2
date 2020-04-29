using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduzione
{
    public class Validazione
    {
        private string UserID { get; set; }
        private string UserPSW { get; set; }
        
        public string getUser()
        {
            return UserID;
        } 
        public void setUser(string user)
        {
            this.UserID = user;
        }

        public string getPSW()
        {
            return UserPSW;
        }
        public void setPSW(string psw)
        {
            this.UserPSW = psw;
        }
    }


}