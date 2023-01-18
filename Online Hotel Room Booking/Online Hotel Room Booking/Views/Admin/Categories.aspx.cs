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
            ShowCategories();
            LogedUser.InnerText = Session["UserName"] as string;
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCategories()
        {
            string Query = "select CatId as Id, CatName as Categories, CatRemarks as Remarks from CategoryTb1";
            CategoriesGV.DataSource = Con.GetData(Query);
            CategoriesGV.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CatName = CatNameTb.Value;
                string Rem = RemarksTb.Value;
                string Query = "insert into CategoryTb1 Values('{0}','{1}')";
                Query = string.Format(Query, CatName, Rem);
                Con.setData(Query);
                ShowCategories();  
                ErrMsg.InnerText = "Catgory Added!!!";
            }
            catch(Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int Key = 0;
        protected void CategoriesGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(CategoriesGV.SelectedRow.Cells[1].Text);
            CatNameTb.Value = CategoriesGV.SelectedRow.Cells[2].Text;
            RemarksTb.Value = CategoriesGV.SelectedRow.Cells[3].Text;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CatName = CatNameTb.Value;
                string Rem = RemarksTb.Value;
                string Query = "update CategoryTb1 set CatName='{0}',CatRemarks='{1}' where CatId = {2}";
                Query = string.Format(Query, CatName, Rem, CategoriesGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowCategories();
                ErrMsg.InnerText = "Catgory Updated!!!";
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
                string CatName = CatNameTb.Value;
                string Rem = RemarksTb.Value;
                string Query = "Delete from CategoryTb1 where CatId = {0}";
                Query = string.Format(Query, CategoriesGV.SelectedRow.Cells[1].Text);
                Con.setData(Query);
                ShowCategories();
                ErrMsg.InnerText = "Catgory Deleted!!!";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click1(object sender, EventArgs e)
        {

        }
    }
}
