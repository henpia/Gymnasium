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
            // Bind the GridView to a list of deleted/slettede fag.
            // 1. get a list of Fag (deleted) to display
            var slettedeFagListe = Domain.FagManager.HentSlettedeFag();
            // 2. set the source of the gridview to the list of fag from above
            // 3. bind the source to the gridview
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FagListe.aspx");
        }

        protected void slettedeFagGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Determine which row is clicked
        }
    }
}