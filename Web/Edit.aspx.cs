using Client.ingredients;
using Client.services;
using Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Edit : System.Web.UI.Page
    {
        private RecepiesServices recepiesServices = new RecepiesServices();
        public String Id = HttpContext.Current.Request.Url.AbsolutePath;
        public static Recepie Recepie;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var num = Id.Split('/');
                var id = Convert.ToInt32(num[num.Length - 1]);
                Recepie = recepiesServices.GetById(id);
                
                CategoryService.Categories.ForEach(x => Category.Items.Add(x));

                Name.Value = Recepie.Name;
                Description.Value = Recepie.Description;
                Category.Value = Recepie.Category;
                Difficulty.Value = Recepie.Difficulty.ToString();
                Duration.Value = Recepie.Duration.ToString();
            }
           
        }

        protected void Save(object sender, EventArgs e)
        {
            Recepie.Name = Name.Value;
            Name.Value = Recepie.Name;
            Recepie.Description = Description.Value;
            Recepie.Category = Category.Value;
            Recepie.Difficulty = Convert.ToInt16(Difficulty.Value);
            Recepie.Duration = Convert.ToInt16(Duration.Value);

            recepiesServices.Create(Recepie);
            Response.Redirect("/");
        }
    }
}