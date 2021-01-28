using Client.ingredients;
using Client.services;
using Domain.ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Create : System.Web.UI.Page
    {
        public static List<Ingredient> ingredients;
        public RecepiesServices recepiesServices = new RecepiesServices();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ingredients = new List<Ingredient>();
                CategoryService.Categories.ForEach(x => RecipeCategory.Items.Add(x));
            }
        }

        protected void AddIngredient(object sender, EventArgs e)
        {
            ingredients.Add(new Ingredient()
            {
                Name = IngredientName.Value,
                Measure = IngredientMeasure.Value,
                Quantity = Convert.ToInt32(IngredientQuantity.Value)
            });

            IngredientName.Value = "";
            IngredientMeasure.Value = "";
            IngredientQuantity.Value = "";
        }

        protected void Save(object sender, EventArgs e)
        {
            recepiesServices.Create(new Domain.Recepies.Recepie()
            {
                Name = RecipeName.Value, 
                Category = RecipeCategory.Value, 
                Description = RecipeDescription.Value, 
                Difficulty = Convert.ToInt32(RecipeDifficulty.Value), 
                Duration = Convert.ToInt32(RecipeDuration.Value), 
                Ingredients = ingredients, 
                Status = Domain.Recepies.RecepieStatus.Accepted,
                isActive = true
            });

            Response.Redirect("/");
        }
    }
}
