using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Introduzione
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void BTNSubmitLogin_Click(object sender, EventArgs e)
        {
            List<Validazione> validLogin = new List<Validazione>();

            for (int i = 0; i < 5; i++)
            {
                var v = new Validazione();
                string newUser = "utente" + i;
                string newPsw = "psw" + i;
                v.setUser(newUser);
                v.setPSW(newPsw);
                validLogin.Add(v);
            }
            
            bool userFound = false;
            bool isLogged = false;

            foreach (Validazione v in validLogin)
            {
                if (v.getUser() == userID.Text && v.getPSW() == pswID.Text)
                {
                    isLogged = true;
                    Session["currentUser"] = v.getUser();
                    Session["currentPsw"] = v.getPSW();
                    Session["logged"] = isLogged;
                    
                    //LBLOutLogin.Text = "login corretto";
                    Response.Redirect("Import.aspx", true);
                    //userFound = true;
                    break;
                }
                
                LBLOutLogin.Text = "login errato";
                Response.Redirect("forbidden.html", true);
            }
            /*
            if (!userFound)
            {
                LBLOutLogin.Text = "login errato";
            }
            */
        }
    }
}