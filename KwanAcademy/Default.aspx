<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KwanAcademy._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
            <form action="">
                <h2>Sign Up</h2>
                <label for="signup_name">Nombre:</label>
                <input type="text" id="signup_name" name="signup_name" required />               
            </form>
        </section>
    </main>

</asp:Content>
