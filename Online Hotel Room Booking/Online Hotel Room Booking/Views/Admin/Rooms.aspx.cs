using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Online_Hotel_Room_Booking.Views.Admin
{
    public partial class Rooms : System.Web.UI.Page
    {
        models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new models.Functions();
            ShowRooms();
            GetCategories();
        }
        private void ShowRooms()
        {
            string Query = "select * from RoomTb1";
            RoomsGV.DataSource = Con.GetData(Query);
            RoomsGV.DataBind();
        }
        private void GetCategories()
        {
            string Query = "Select * from CategoryTb1";
            CatCb.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            CatCb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();
            CatCb.DataSource = Con.GetData(Query);
            CatCb.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RNameTb.Value;
                string RCat = CatCb.SelectedValue.ToString();
                string RLocation = LocationTb.Value;
                string RCost = CostTb.Value;
                string RRemarks = RemarksTb.Value;
                string Status = "Available";
                string Query = "insert into RoomTb1 Values('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, RName,RCat,RLocation,RCost,RRemarks,Status);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Added!!!";
                RNameTb.Value = "";
                CatCb.SelectedIndex = -1;
                LocationTb.Value = "";
                CostTb.Value = "";
                RemarksTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void RoomsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(RoomsGV.SelectedRow.Cells[1].Text);
            RNameTb.Value = RoomsGV.SelectedRow.Cells[2].Text;
            CatCb.SelectedValue = RoomsGV.SelectedRow.Cells[3].Text;
            LocationTb.Value = RoomsGV.SelectedRow.Cells[4].Text;
            CostTb.Value = RoomsGV.SelectedRow.Cells[5].Text;
            RemarksTb.Value = RoomsGV.SelectedRow.Cells[6].Text;
            StatusCb.SelectedValue = RoomsGV.SelectedRow.Cells[7].Text;
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RNameTb.Value;
                string RCat = CatCb.SelectedValue.ToString();
                string RLocation = LocationTb.Value;
                string RCost = CostTb.Value;
                string RRemarks = RemarksTb.Value;
                string Status = StatusCb.SelectedValue.ToString();
                string Query = "update RoomTb1 set RName='{0}',RCategory='{1}',RLocation='{2}',RCost='{3}',RRemarks='{4}',Status='{5}' where RId={6}";
                Query = string.Format(Query, RName, RCat, RLocation, RCost, RRemarks, Status, RoomsGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Updated!!!";
                RNameTb.Value = "";
                CatCb.SelectedIndex = -1;
                LocationTb.Value = "";
                CostTb.Value = "";
                RemarksTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Delete from RoomTb1 where RId = {0}";
                Query = string.Format(Query, RoomsGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowRooms();
                ErrMsg.InnerText = "Room Deleted!!!";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}