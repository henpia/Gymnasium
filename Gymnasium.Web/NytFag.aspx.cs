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

        protected void opretFagButton_Click(object sender, EventArgs e)
        {
            var fagDTO = new DTO.FagDTO();
            fagDTO.FagId = Guid.NewGuid();
            fagDTO.Navn = "Sløjd";
            fagDTO.Beskrivelse = "Dette fag skal fremme elevernes håndværksmæssige færdigheder.";
            Domain.FagManager.OpretFag(fagDTO);
        }

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}