using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoStart
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);
            c = a + b;
            txtr.Text = c.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);
            c = a - b;
            txtr.Text = c.ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);
            c = a * b;
            txtr.Text = c.ToString();
        }

        protected void lnkNames_Click(object sender, EventArgs e)
        {
            Response.Redirect("names.aspx");
        }
    }
}