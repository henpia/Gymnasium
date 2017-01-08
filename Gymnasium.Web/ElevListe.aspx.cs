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
            refreshGridView();
        }

        protected void elevListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = elevListeGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var elevId = int.Parse(value);
            Domain.ElevManager.SletElev(elevId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            var elever = Domain.ElevManager.HentElever();
            elevListeGridView.DataSource = elever;
            elevListeGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


        protected void slettedeEleverButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("slettedeEleverListe.aspx");
        }
    }
}