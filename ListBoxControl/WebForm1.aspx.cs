using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Response.Write(li.Value + "<br/>");
                    Response.Write(li.Text + "<br/>");
                    Response.Write(ListBox1.Items.IndexOf(li).ToString() + "<br/>");
                    Response.Write("---------------------------------------------");
                }
            }
        }
    }
}