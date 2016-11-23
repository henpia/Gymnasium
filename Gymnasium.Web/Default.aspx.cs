using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void nyLærerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("NyLærer.aspx");
        }

        protected void listeLærerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LærerListe.aspx");
        }

        protected void nytFagButton_Click(object sender, EventArgs e)
        {
            // TODO: Impelement opretFagButton_Click event
        }

        protected void listeFagButton_Click(object sender, EventArgs e)
        {
            // TODO: Impelement listeFagButton_Click event
        }

        protected void nyElevButton_Click(object sender, EventArgs e)
        {
            // TODO: Impelement opretElevButton_Click event
        }

        protected void listeElevButton_Click(object sender, EventArgs e)
        {
            // TODO: Impelement listeElevButton_Click event
        }
    }
}