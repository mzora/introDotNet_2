using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Introduzione
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void BTNSubmitLogin_Click(object sender, EventArgs e)
        {
            if (DAL.validLogin(UserLogin.Text, PswLogin.Text))
            {
                Session["currentUser"] = UserLogin.Text;
                Session["currentPsw"] = PswLogin.Text;
                Response.Redirect("Import.aspx", true);
            }
            else
            {
                Response.Redirect("forbidden.html", true);
            }
            /*
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
            
            //bool userFound = false;
            bool isLogged = false;

            foreach (Validazione v in validLogin)
            {
                if (v.getUser() == UserLogin.Text && v.getPSW() == PswLogin.Text)
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