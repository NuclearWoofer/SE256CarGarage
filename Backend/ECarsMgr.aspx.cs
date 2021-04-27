using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using SE256_Lab_MikeL.App_Code;


namespace SE256_Lab_MikeL.Backend
{
    public partial class ECarsMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //we can stay
            }
            else
            {
                Response.Redirect("~/Backend/Default.aspx"); //Boot back
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Cars temp = new Cars();


            temp.CarMake = txtCarMake.Text;
            temp.CarModel = txtCarModel.Text;
            temp.CarStyle = txtCarStyle.Text;
            temp.CarYear = calCarYear.SelectedDate;

            //if number of cylinders is valid int, copy it to obj
            Int32 intCylinders = 0;
            if (Int32.TryParse(txtCarCylinders.Text, out intCylinders))
            {
                temp.CarCylinders = intCylinders;
            }

            Double dblPrice = 0;
            if(Double.TryParse(txtCarPurchasePrice.Text, out dblPrice))
            {
                temp.CarPurchasePrice = dblPrice;

            }

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                //info added
                lblFeedback.Text = temp.AddARecord();
            }

        }
    }
}