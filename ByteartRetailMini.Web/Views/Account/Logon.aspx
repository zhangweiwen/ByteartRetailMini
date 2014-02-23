<%@ Page Title="账户设置" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="ByteartRetailMini.Web.Views.Account.Logon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<hgroup class="title">
    <h1><img src="/Images/User_32.png" alt=""/>账户设置</h1>    
</hgroup>
<section id="loginForm">
    <h4>请向系统提供您的用户名和密码以便登录</h4>
    <form runat="server">
        <div class="validation-summary-errors" runat="server" ID="ValidationError" Visible="False">
            <ul>
                <li>用户名或密码不正确！</li>
            </ul>
        </div>
        <div>
            <label for="UserName">用户名</label>
        </div>
        <div>
            <input data-val="true" data-val-required="用户名 字段是必需的。" id="UserName" name="UserName" type="text" value="" class="valid">
            <span class="field-validation-valid" data-valmsg-for="UserName" data-valmsg-replace="true"></span>
        </div>
        <div>
            <label for="Password">密码</label>
        </div>
        <div>
            <input data-val="true" data-val-required="密码 字段是必需的。" id="Password" name="Password" type="password">
            <span class="field-validation-valid" data-valmsg-for="Password" data-valmsg-replace="true"></span>
        </div>
        <div>
            <input data-val="true" data-val-required="记住密码？ 字段是必需的。" id="RememberMe" name="RememberMe" type="checkbox" value="true">
            <label class="checkbox" for="RememberMe">记住密码？</label>
        </div>
        <p>
            <asp:Button ID="LoginBtn" runat="server" Text="登录" OnClick="OnLoginBtnClick"></asp:Button>
        </p>
    </form>
</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#UserName").focus();
        });
    </script>
</asp:Content>