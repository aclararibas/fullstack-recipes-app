<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Web.Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset disabled>
        <div class="form-group">
          <label for="disabledTextInput">Name</label>
          <input type="text" id="Name" class="form-control" runat="server"/>

          <label for="disabledTextInput">Description</label>
          <input type="text" id="Description" class="form-control" runat="server" />

          <label for="disabledTextInput">Category</label>
          <input type="text" id="Category" class="form-control" runat="server" />

          <label for="disabledTextInput">Difficulty</label>
          <input type="text" id="Difficulty" class="form-control" runat="server" />
          
          <label for="disabledTextInput">Duration</label>
          <input type="text" id="Duration" class="form-control" runat="server" />

          <label for="disabledTextInput">Ingredients</label>
          
            <table class="table table-striped">
                <thead class="thead-dark">
                    <tr>
                        <th>Name</th>
                        <th>Quantity</th>
                        <th>Measure</th>
                    </tr>
                </thead>

                <tbody>
                   <% foreach (var item in Recepie.Ingredients) { %>
                    <tr>
                        <td><%= item.Name %></td>
                        <td><%= item.Quantity %></td>
                        <td><%= item.Measure %></td>
                    </tr>
                    <% } %>
                </tbody>
             </table>

          <label for="disabledTextInput">Created At</label>
          <input type="text" id="CreatedAt" class="form-control" runat="server" />
        </div>
    </fieldset>

</asp:Content>
