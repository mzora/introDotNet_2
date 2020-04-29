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
            //bool userFound = false;
            foreach (Validazione v in validLogin)
            {
                if (v.getUser() == userID.Text && v.getPSW() == pswID.Text)
                {
                    Response.Redirect("Import.aspx", true);
                    //LBLOutLogin.Text = "login corretto";
                    //userFound = true;
                    //break;
                }
                LBLOutLogin.Text = "login errato";
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