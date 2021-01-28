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
    public partial class _Default : Page
    {
        private RecepiesServices recepiesServices = new RecepiesServices();

        public ISet<Recepie> recepies;

        protected void Page_Load(object sender, EventArgs e)
        {
            recepies = recepiesServices.GetAll();
        }

        protected void LinkButtonDelete_Click(object sender, EventArgs e) 
        {
            var id = (sender as LinkButton).CommandArgument.ToString();
            recepiesServices.DeleteById(Convert.ToInt32(id));
            recepies = recepiesServices.GetAll();
        }
    }
}