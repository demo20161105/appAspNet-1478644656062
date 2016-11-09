using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo01
{
    public partial class wfHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtPrueba.Text = "Este mensaje es UN EXITO!!!!  :D";

        }
    }
}