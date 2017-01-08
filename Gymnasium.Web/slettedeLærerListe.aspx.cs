using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class slettedeLærerListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void slettedeLærereGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = slettedeLærereGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var lærerId = int.Parse(value);
            Domain.LærerManager.SletLærerPermanent(lærerId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            List<DTO.LærerDTO> slettedeLærere = Domain.LærerManager.HentSlettedeLærere();
            slettedeLærereGridView.DataSource = slettedeLærere;
            slettedeLærereGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LærerListe.aspx");
        }

    }
}