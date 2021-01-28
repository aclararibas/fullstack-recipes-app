<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Web.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container" style="font-size:14px;">
            
                <label>Name</label>
                <input type="text" class="form-control input-lg" id="RecipeName" placeholder="Recipe Name" runat="server">
                
                <label>Description</label>
                <input type="text" class="form-control" id="RecipeDescription" placeholder="Recipe Description" runat="server">

                <label>Category </label>
                <br />
                <select class="custom-select" id="RecipeCategory" runat="server" required >
                     <option selected disabled value="">Select</option>
                </select>

                <br />

                <label>Difficulty</label>
                <input type="number" class="form-control" id="RecipeDifficulty" placeholder="Recipe Difficulty" runat="server">

                <label>Duration</label>
                <input type="number" class="form-control" id="RecipeDuration" placeholder="Recipe Duration" runat="server">
                
                <h4>Ingredients</h4>
     
                <label>Name</label>
                <input type="text" class="form-control" id="IngredientName" placeholder="Ingredient Name" runat="server">

                <label>Quantity</label>
                <input type="number" class="form-control" id="IngredientQuantity" placeholder="Ingredient Quantity" runat="server">

                <label>Measure</label>
                <input type="text" class="form-control" id="IngredientMeasure" placeholder="Ingredient Measure" runat="server">
                <br />
                
                <button type="button" class="btn btn-primary btn-md" onserverClick="AddIngredient" runat="server">Add Ingredient</button>
                
                <br />
                <br />

                 <table class="table table-striped">
                    <thead class="thead-dark">
                        <tr>
                            <th>Name</th>
                            <th>Quantity</th>
                            <th>Measure</th>
                        </tr>
                    </thead>

                    <tbody>
                        <% foreach (var item in ingredients) { %>
                        <tr>
                            <td><%= item.Name %></td>
                            <td><%= item.Quantity %></td>
                            <td><%= item.Measure %></td>
                        </tr>
                        <% } %>
                    </tbody>
                </table>
                
            <br />
            <button  type="button" class="btn btn-primary btn-md" runat="server" onserverClick="Save">Save</button>
        </form>
    </div>
</asp:Content>
