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

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FagListe.aspx");
        }

        protected void slettedeFagGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Determine which row is clicked
            int index = Convert.ToInt32(e.CommandArgument);
            // Create a new GridViewRow object and assign the clicked row to the row property
            GridViewRow row = slettedeFagGridView.Rows[index];
            // Return the value of cell 0 (the first cell) from the row found above. Cell 0 is fagId. Convert it to a string
            var value = row.Cells[0].Text.ToString();
            var fagId = int.Parse(value);
            // Permanently delete the Fag record
            Domain.FagManager.SletFagPermanent(fagId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            // Bind the GridView to a list of deleted/slettede fag.
            // 1. get a list of Fag (deleted) to display
            var slettedeFagListe = Domain.FagManager.HentSlettedeFag();
            // 2. set the source of the gridview to the list of fag from above
            slettedeFagGridView.DataSource = slettedeFagListe;
            // 3. bind the source to the gridview
            slettedeFagGridView.DataBind();
        }

    }
}