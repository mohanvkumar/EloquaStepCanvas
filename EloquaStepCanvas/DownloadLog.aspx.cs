using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EloquaStepCanvas
{
    public partial class DownloadLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hypDownloadLog.NavigateUrl = Server.MapPath("PhilipsEloqua.log");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Step Id : " + Convert.ToString(Request.QueryString["StepID"]));
        }
    }
}