using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class slettedeFagListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void slettedeFagGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = slettedeFagGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var fagId = int.Parse(value);
            Domain.FagManager.SletFagPermanent(fagId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            var slettedeFagListe = Domain.FagManager.HentSlettedeFag();
            slettedeFagGridView.DataSource = slettedeFagListe;
            slettedeFagGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FagListe.aspx");
        }

    }
}