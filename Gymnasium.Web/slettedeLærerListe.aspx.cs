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