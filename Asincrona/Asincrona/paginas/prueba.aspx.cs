using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asincrona.paginas
{
    public partial class prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rpta = "";
            if (!Page.IsPostBack)
            {
                rpta = "Primera Vez";
            }
            else
            {
                rpta = "Postback";
            }
        }
    }
}