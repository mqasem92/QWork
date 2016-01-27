using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QWork.Core.Enum;
using QWork.Extension;

namespace QWork.Test.WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Default.aspx?text=mohamed&value=5");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}