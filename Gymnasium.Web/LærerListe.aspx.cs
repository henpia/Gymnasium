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

        protected void lærerListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = lærerListeGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var lærerId = int.Parse(value);
            Domain.LærerManager.SletLærer(lærerId);
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


        protected void slettedeLærerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("slettedeLærerListe.aspx");
        }
    }
}