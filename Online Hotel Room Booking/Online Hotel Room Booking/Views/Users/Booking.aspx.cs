using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Hotel_Room_Booking.Views.Users
{
    public partial class Booking : System.Web.UI.Page
    {
        models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new models.Functions();
            ShowRooms();
        }
        private void ShowRooms()
        {
            string Query = "select * from RoomTb1";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }
    }
}