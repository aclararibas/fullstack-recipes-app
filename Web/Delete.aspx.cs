using Client.ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Delete : System.Web.UI.Page
    {
        private RecepiesServices recepiesServices = new RecepiesServices();

        public String Id = HttpContext.Current.Request.Url.AbsolutePath;
        protected void Page_Load(object sender, EventArgs e)
        {
            var num = Id.Split('/');
            var id = Convert.ToInt32(num[num.Length - 1]);
            recepiesServices.DeleteById(id);

            Response.Redirect("/");
        }
    }
}