<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Categories.ascx.cs" Inherits="ByteartRetailMini.Web.Controls.Categories" %>
<table width="202" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td height="320" align="left" valign="top">
            <div class="category">
                <img src="/Images/spacer.gif" alt="" width="30" height="19">商品分类
                <a href="http://daxnet.cnblogs.com/">
                    <img src="/Images/spacer.gif" alt="" width="10" height="10" border="0"/>
                </a>
            </div>
            <div class="linkmenu">
                <img src="/Images/spacer.gif" alt="" width="20" height="19"/>
                <span class="red">&bull;</span>&nbsp;&nbsp;
                <a href="/Home/Category">所有商品</a>
            </div>
            <asp:Repeater runat="server" ID="CategoriesRpt">
                <ItemTemplate>
                    <div class="linkmenu">
                        <img src="/Images/spacer.gif" alt="" width="20" height="19"/>
                        <span class="red">&bull;</span>&nbsp;&nbsp;
                        <a runat="server" ID="CategoryLink"/>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </td>
    </tr>
    <tr>
        <td height="26">&nbsp;</td>
    </tr>
    <tr>
        <td align="center"><a href="http://daxnet.cnblogs.com/">
        <img src="/Images/banner.jpg" alt="" width="197" height="215" border="0"></a></td>
    </tr>
</table>