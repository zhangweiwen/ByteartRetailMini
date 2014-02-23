<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Logon.ascx.cs" Inherits="ByteartRetailMini.Web.Controls.Logon" %>
<table style="width: 100%;" runat="server" ID="WellcomeTable">
    <tr>
        <td class="loginPartial_ShoppingCartIcon">
            <img src="/Images/ShoppingCart.png" alt="ShoppingCart"/>
        </td>
        <td class="loginPartial_ShoppingCartHint">
            <span class="loginPartial_Text">欢迎您，<%= Context.User.Identity.Name %></span>
            <br />
            <a href="/Home/ShoppingCart">
                <span class="loginPartial_ShoppingCartItemNumber" runat="server" ID="ShoppingCartCountSpan"></span>
                <span class="loginPartial_Text">个商品</span>
            </a>
        </td>
        <td class="loginPartial_LogOffIcon">
            <form action="/Account/LogOff" id="logoutForm" method="post" novalidate="novalidate">
                <span class="loginPartialLink">
                    <a href="javascript:if (confirm('是否确认退出？')) document.getElementById('logoutForm').submit()">退出</a>
                </span>
            </form>
        </td>
    </tr>
</table>
<table class="loginPartialLink" runat="server" ID="LogonTable">
    <tr>
        <td style="width:100%; text-align: right">
            <a href="/Account/Logon" >登录</a>
        </td>
    </tr>
</table>