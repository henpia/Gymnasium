﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gymnasium.Web
{
    public partial class NytFag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void opretFagButton_Click(object sender, EventArgs e)
        {
            var fagDTO = new DTO.FagDTO();
            fagDTO.Navn = navnTextBox.Text;
            fagDTO.Beskrivelse = beskrivelseTextBox.Text;
            Domain.FagManager.OpretFag(fagDTO);
        }

    }
}