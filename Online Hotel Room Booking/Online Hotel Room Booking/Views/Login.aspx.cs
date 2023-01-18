using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Hotel_Room_Booking.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new models.Functions();
            Session["UserName"] = "";
            Session["UId"] = "";
        }
        models.Functions Con;

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Admin/Rooms.aspx");
            
            if(AdminCb.Checked)
            {
                if(UserTb.Value=="Admin" && PasswordTb.Value == "Password")
                {
                    Session["UserName"] = "Admin";
                    Response.Redirect("Admin/Room.aspx");
                }
                else
                {
                    ErrMsg.InnerText = "Invalid Admin!!!";
                }
            }else
            {
                //Session["UserName"] = "Admin";
                string Query = "select UId,UName,UPass from UserTb1 where UName='{0}' and UPass='{1}'";
                Query = string.Format(Query, UserTb.Value,PasswordTb.Value);
                DataTable dt = Con.GetData(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid User!!!";
                }
                else
                {
                    Session["UserName"] = dt.Rows[0][1].ToString();
                    Session["UId"] = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Users/Booking.aspx");
                }
            }
        }
    }
}