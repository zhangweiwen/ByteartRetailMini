<%@ Page Title="订单生成" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ByteartRetailMini.Web.Views.Home.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <h1>
        <img src="/Images/Success_32.png" alt=""/>&nbsp;生成订单成功！
    </h1>
    <table id="CheckoutResult">
        <tr>
            <td style="width: 75px;">
                订单编号：
            </td>
            <td>
                <b runat="server" ID="UserId"></b>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top;">
                收货地址：
            </td>
            <td>
                <b runat="server" ID="ZipAndStreet"></b>
                <br />
                <b runat="server" ID="CityAndStateAndCountry"></b>
            </td>
        </tr>
        <tr>
            <td>
                联系人：
            </td>
            <td>
                <b runat="server" ID="CustomerContact"></b>
            </td>
        </tr>
        <tr>
            <td>
                联系电话：
            </td>
            <td>
                <b runat="server" ID="CustomerPhone"></b>
            </td>
        </tr>
        <tr>
            <td>
                电子邮件：
            </td>
            <td>
                <b runat="server" ID="CustomerEmail"></b>
            </td>
        </tr>
    </table>
    <p />
    <div>
        您可以 
        <a class="blue1" runat="server" ID="SalesOrderLink">单击此处</a>
        查看此订单的详细信息，或者
        <a class="blue1" href="/Home/SalesOrder">单击此处</a> 
        查看所有订单。
    </div>
    <p />
    <div>
        请 
        <a href="/Home/Index" class="blue1">单击此处</a>
        回到首页继续购物。
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContent" runat="server">
</asp:Content>
