using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class slettedeEleverListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void slettedeEleverGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = slettedeEleverGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var elevId = int.Parse(value);
            Domain.ElevManager.SletElevPermanently(elevId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            List<DTO.ElevDTO> slettedeElever = Domain.ElevManager.HentSlettedeElever();
            slettedeEleverGridView.DataSource = slettedeElever;
            slettedeEleverGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ElevListe.aspx");
        }

    }
}