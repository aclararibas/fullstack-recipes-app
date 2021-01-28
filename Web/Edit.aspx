<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Web.Edit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <label>Name</label>
    <input type="text" id="Name" class="form-control" runat="server"/>

    <label>Description</label>
    <input type="text" id="Description" class="form-control" runat="server" />

    <label>Category</label>

    <br />
    <select class="custom-select" id="Category" runat="server" required >
        <option selected disabled value="">Select</option>
    </select>

    <br />
    <label>Difficulty</label>
    <input type="text" id="Difficulty" class="form-control" runat="server" />
          
    <label>Duration</label>
    <input type="text" id="Duration" class="form-control" runat="server" />

    <br />
    <button  type="button" class="btn btn-primary" runat="server" onserverClick="Save">Save</button>

</asp:Content>
