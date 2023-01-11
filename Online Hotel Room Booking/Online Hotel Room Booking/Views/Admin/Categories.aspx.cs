using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Hotel_Room_Booking.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new models.Functions();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        try
        {
        }
        catch(Exception)
            {
            throw;
}
    }
}
