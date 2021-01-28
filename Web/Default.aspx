<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>ID</th>
                <th>Recipe Name</th>
                <th>Operations</th>
            </tr>
        </thead>

        <tbody>
            <% foreach (var recipe in recepies) { %>
                <tr>
                    <th scope="row"><%= recipe.Id %></th>
                    <td><%= recipe.Name %></td>
                    <td>
                        <a href=<%= "Edit/" + recipe.Id %>>Edit</a>
                        | <a href=<%= "Delete/" + recipe.Id %>>Delete</a>
					    |  <a href=<%= "Details/" + recipe.Id %>>Details</a> 
                    </td>
                </tr>
            <% } %>
        </tbody>
    </table>

</asp:Content>
