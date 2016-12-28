using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class LærerListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void refreshGridView()
        {
            var lærere = Domain.LærerManager.HentLærere();
            lærerListeGridView.DataSource = lærere;
            lærerListeGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void lærerListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // TODO: Implement the delete functionality for a lærer/teacher
            // Change the below hardcode to find the guid of the clicked row.
            Guid lærerId = Guid.Parse("84aad1a8-03e2-4789-a0f2-ec3f81b32445");
            Domain.LærerManager.SletLærer(lærerId);
            refreshGridView();
        }

        protected void slettedeLærerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("slettedeLærerListe.aspx");
        }
    }
}