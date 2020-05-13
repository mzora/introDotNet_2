using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Introduzione
{
    public partial class Import : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] == null)
            {
                Response.Redirect("Default.aspx", true);
            }
            LBLLoggedName.Text = "Benvenuto: " + Session["currentUser"].ToString();

            GRDPerson.DataSource = DAL.getPersone();
            GRDPerson.DataBind();
        }

        protected void GRDPerson_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
        }

        protected void BTNSubmit_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cognome = TXTCognome.Text;
            persona.Nome = TXTNome.Text;
            persona.Eta = TXTEta.Text;
            persona.Username = TXTUsername.Text;
            persona.Password = TXTPsw.Text;
            DAL.insertUser(persona);
            //contatore istanze
            Persona.NumOfObj += 1;
        }

        protected void BTNSubmitTab_Click(object sender, EventArgs e)
        {
            GRDPerson.DataSource = DAL.getPersone();
            GRDPerson.DataBind();
        }

    }
}