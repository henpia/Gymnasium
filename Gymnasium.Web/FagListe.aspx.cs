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

        protected void tilbageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void fagListeGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void fagListeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Determine which row is clicked
            int index = Convert.ToInt32(e.CommandArgument);
            // Create a new GridviewRow object and assign the clicked row to the row property
            GridViewRow row = fagListeGridView.Rows[index];
            // Return the value of cell 0 (the first cell) from the row found above.  Cell 0 is the fagId. Convert it to a string.
            var value = row.Cells[0].Text.ToString();
            // Determine which Fag is displayed on the clicked row (fagid of clicked row)
            var fagId = int.Parse(value);
            // delete the found fagid
            Domain.FagManager.SletFag(fagId);

            // Refresh page / refreshGridView
            refreshGridView();
        }

        private void refreshGridView()
        {
            // Get a list of Fag
            List<DTO.FagDTO> fagDTO = Domain.FagManager.HentFag();
            // Set the Gridview source to be the list of fag
            fagListeGridView.DataSource = fagDTO;
            // Bind the source to the Gridview
            fagListeGridView.DataBind();            
        }

        protected void slettedeFagButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("slettedeFagListe.aspx");
        }

        
    }
}