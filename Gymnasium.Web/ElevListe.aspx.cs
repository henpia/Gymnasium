using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class ElevListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Populate the Elev List gridview
            var elever = Domain.ElevManager.HentElever();
            elevListeGridView.DataSource = elever;
            elevListeGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void elevListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // TODO: Implement the slet/delete funtionality for Elev
        }
    }
}