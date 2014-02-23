<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Products.ascx.cs" Inherits="ByteartRetailMini.Web.Controls.Products" %>
<h2 runat="server" ID="CategoryName" Visible="False"></h2>
<table width="774" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td height="479">&nbsp;</td>
        <td align="left" valign="top" width="100%">
            <asp:Repeater runat="server" ID="ProductsRpt">
                <ItemTemplate>
                    <table width="207" height="234" border="0" cellpadding="0" cellspacing="0" class="productleft_top">
                    <tr>
                        <td align="left" valign="top">
                            <table width="222" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td height="200" valign="top">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td height="45">
                                                    <span class="product_name">
                                                        <a runat="server" ID="ProductNameLink"></a>
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="147" align="center">
                                                    <a runat="server" ID="ProductImgLink">
                                                        <img runat="server" ID="ProductImg" alt="" width="175" height="144" border="0"/>
                                                    </a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td width="24%" height="24">
                                                    <span class="style7">
                                                        <a runat="server" ID="DetailLink" class="blue1">详细信息</a>
                                                    </span>
                                                </td>
                                                <td width="5%">&nbsp;</td>
                                                <td width="15%" height="24">
                                                    <span class="style7">
                                                        <a runat="server" ID="BuyLink" class="blue1">购买</a>                                                        
                                                    </span>
                                                </td>
                                                <td width="5%">&nbsp;</td>
                                                <td width="51%" class="price" runat="server" ID="PriceTd"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
            <table style="width: 100%">
                <tr>
                    <td style="text-align: right; font-size: 12px;">
                        <span runat="server" ID="PageSummary"></span>
                        &nbsp;
                        <a runat="server" ID="FirstLink">首页</a>
                        &nbsp;
                        <a runat="server" ID="PrevLink">上页</a>
                        &nbsp;
                        <a runat="server" ID="NextLink">下页</a>
                        &nbsp;
                        <a runat="server" ID="LastLink">尾页</a>
                    </td>
                </tr>
            </table>
            <h4 runat="server" ID="NotFoundMsg" Visible="False">没有找到任何商品</h4>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
