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
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCategories()
        {
            string Query = "select CatId as Id, CatName as Categories, CatRemarks as Remarks from CategoriesTb1";
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
    }
}
