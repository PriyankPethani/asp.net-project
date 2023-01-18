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
            string Query = "select RId as Id, RName as Name, RCategory as Categories, RCost as Cost, Status as Status from RoomTb1";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }
        int Key = 0;
        int Days = 1;
        protected void RoomsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(RoomsGV.SelectedRow.Cells[1].Text);
            RoomTb.Value = RoomsGV.SelectedRow.Cells[2].Text;
            int Cost = Days * Convert.ToInt32(RoomsGV.SelectedRow.Cells[4].Text);
            AmountTb.Value =Cost.ToString();
        }

        protected void BookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RId = RoomsGV.SelectedRow.Cells[1].Text;
                string BDate = System.DateTime.Today.Date.ToString();
                string InDate = DateInTb.Value;
                string OutDate = DateOutTb.Value;
                string Agent = Session["UId"] as string;
                int Amount = Convert.ToInt32(AmountTb.ToString());
                string Query = "insert into BookingTb1 Values('{0}','{1}','{2}','{3}','{4}',{5})";
                Query = string.Format(Query, BDate, RId, Agent, InDate, OutDate, Amount);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Booked!!!";
                RoomTb.Value = "";
                AmountTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}