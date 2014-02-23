<%@ Page Title="主页" Language="C#" MasterPageFile="~/Views/Site.master" AutoEventWireup="true"
    CodeBehind="Index.aspx.cs" Inherits="ByteartRetailMini.Web.Views.Home.Index" %>
<%@ Register TagPrefix="my" tagName="Products" src="/Controls/Products.ascx"%>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table width="774" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td height="40" class="popular">
                <img src="/Images/spacer.gif" alt="" width="27" height="19"/>
                <span class="popular_text">特色商品推荐</span>
            </td>
        </tr>
        <tr>
            <td height="138" valign="top" class="popular_center">
                <table width="774" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="15">&nbsp;</td>
                        <td width="743">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <asp:Repeater runat="server" ID="ProductRpt">
                                        <ItemTemplate>
                                            <td width="21%" height="148" align="center">
                                                <a href="#" runat="server" ID="ProductLink">
                                                    <img src="#" runat="server" ID="ProductImg" alt="" width="140" height="117" border="0">
                                                </a>
                                                <br>
                                                <span class="style7">
                                                    <a href="#" runat="server" ID="ProductTextLink"></a>
                                                </span>
                                            </td>
                                        </ItemTemplate>
                                        <SeparatorTemplate>
                                            <td runat="server" id="SeparateTD" width="2%" align="center">
                                                <img src="/Images/op.jpg" width="14" height="117" alt=""/>
                                            </td>
                                        </SeparatorTemplate>
                                    </asp:Repeater>
                                </tr>
                            </table>
                        </td>
                        <td width="16">&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <img src="/Images/close.gif" alt="" width="774" height="9"/>
            </td>
        </tr>
    </table>
    <my:Products ID="Products" runat="server"></my:Products>
</asp:Content>