using Client.ingredients;
using Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Details : System.Web.UI.Page
    {
        private RecepiesServices recepiesServices = new RecepiesServices();
        public String Id = HttpContext.Current.Request.Url.AbsolutePath;
        public Recepie Recepie;

        protected void Page_Load(object sender, EventArgs e)
        {
            var num = Id.Split('/');
            var id = Convert.ToInt32(num[num.Length - 1]);
            Recepie = recepiesServices.GetById(id);
            Name.Value = Recepie.Name;
            Description.Value = Recepie.Description;
            Difficulty.Value = Recepie.Difficulty.ToString();
            Duration.Value = Recepie.Duration.ToString();
            CreatedAt.Value = Recepie.CreatedAt.ToString();
            Category.Value = Recepie.Category;
        }
    }
}