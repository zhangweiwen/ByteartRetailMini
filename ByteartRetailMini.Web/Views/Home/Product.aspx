<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ByteartRetailMini.Web.Views.Home.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="width: 135px; text-align: center;">
            <img runat="server" ID="ProductImg" alt=""/>
        </td>
        <td style="text-align:left; vertical-align: top;">
            <table style="width: 100%"> 
                <tr>
                    <td>
                        <h2 runat="server" ID="ProductNameH2"></h2>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold;">
                        <span runat="server" ID="CategoryNameSpan"></span>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td runat="server" ID="ProductDescriptionTd">
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 75%; text-align: right;">
                                    单价：
                                </td>
                                <td class="price" runat="server" ID="PriceTd">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 75%; text-align: right;">
                                    数量：
                                </td>
                                <td style="text-align: left;">
                                     <form id="AddToCartForm" action="/Home/AddToCart" method="POST">
                                        <input type="hidden" name="productID" runat="server" ID="ProductIdInput"/>
                                        <span><input type="text" id="items" name="items" style="width: 30px;" /></span>
                                        <span>
                                            <a href="javascript:document.getElementById('AddToCartForm').submit()" class="blue1">购买</a>
                                        </span>
                                     </form>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContent" runat="server">
<script type="text/javascript">
        $(function () {
            $('#items').val("1");
            $('#items').focus();
        });
</script>
</asp:Content>
