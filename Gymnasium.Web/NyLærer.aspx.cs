using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class NyLærer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void opretLærerButton_Click(object sender, EventArgs e)
        {
            var lærerDTO = new DTO.LærerDTO();
            lærerDTO.CprNummer = cprNummerTextBox.Text.Trim();
            lærerDTO.Navn = navnTextBox.Text.Trim();
            lærerDTO.Adresse = adresseTextBox.Text.Trim();
            Domain.LærerManager.OpretLærer(lærerDTO);
        }
    }
}