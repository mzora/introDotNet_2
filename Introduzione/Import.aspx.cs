using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Introduzione
{
    public partial class Import : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        static List<Persona> persone = new List<Persona>();

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
    }
}