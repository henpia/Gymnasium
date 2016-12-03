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
            // Get a list of Fag
            List<DTO.FagDTO> fagDTO = Domain.FagManager.HentFag();
            // Set the Gridview source to be the list of fag
            fagListeGridView.DataSource = fagDTO;
            // Bind the source to the Gridview
            fagListeGridView.DataBind();
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}