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
        static List<Persona> persone = new List<Persona>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNSubmit_Click(object sender, EventArgs e)
        {
            Persona utente = new Persona();
            utente.Cognome = TXTCognome.Text;
            utente.Nome = TXTNome.Text;
            utente.Eta = int.Parse(TXTEta.Text);
            persone.Add(utente);

            //contatore istanze
            Persona.NumOfObj += 1;

            //GridView tabella
            GRDPerson.DataSource = persone;
            GRDPerson.DataBind();
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
            foreach (Validazione v in validLogin)
            {
                if (v.getUser() == userID.Text && v.getPSW() == pswID.Text)
                {
                    LBLOutLogin.Text = "login corretto";
                    userFound = true;
                    break;
                }

            }
            if (!userFound)
            {
                LBLOutLogin.Text = "login errato";
            }

        }
    }
}