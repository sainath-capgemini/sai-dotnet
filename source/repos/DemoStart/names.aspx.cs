using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoStart
{
    public partial class names : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
                ddlNames.Items.Add("cheekati");
                ddlNames.Items.Add("dela");
                ddlNames.Items.Add("sai");
                ddlNames.Items.Add("nath");
            
        }
            protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
            {
                Response.Write("selected name is  " + ddlNames.Text);
            }
        }
    }
