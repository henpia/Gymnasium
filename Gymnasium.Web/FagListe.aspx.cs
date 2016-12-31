using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class FagListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void fagListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = fagListeGridView.Rows[index];
            var value = row.Cells[0].Text.ToString();
            var fagId = int.Parse(value);
            Domain.FagManager.SletFag(fagId);
            refreshGridView();
        }

        private void refreshGridView()
        {
            List<DTO.FagDTO> fagDTO = Domain.FagManager.HentFag();
            fagListeGridView.DataSource = fagDTO;
            fagListeGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


        protected void slettedeFagButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("slettedeFagListe.aspx");
        }

        
    }
}