<%@ Page Title="我的购物篮" Language="C#" MasterPageFile="~/Views/Site.master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ByteartRetailMini.Web.Views.Home.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<hgroup class="title">
    <h1>
        <img alt="" src="/Images/ShoppingCart32.png"/>&nbsp;<span runat="server" ID="TitleSpan"></span>
    </h1>
</hgroup>
<div>
    <span>我的购物篮中共有</span>
    <span class="ShoppingCart_Count" runat="server" ID="CountSpan"></span>
    <span>条记录，共计</span>
    <span class="ShoppingCart_Count" runat="server" ID="SumSpan"></span>
    <span>件商品</span>
</div>
<div>
        <table id="ShoppingCartTable">
            <thead>
                <tr>
                    <th id="ImageColumn">&nbsp;
                    </th>
                    <th id="NameColumn">名称
                    </th>
                    <th id="UnitPriceColumn">单价
                    </th>
                    <th id="QuantityColumn">数量
                    </th>
                    <th>总价
                    </th>
                    <th id="CommandColumn">更新
                    </th>
                    <th id="CommandColumn">删除
                    </th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="ShoppingCartItemsRpt">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <img alt="" border="0" height="65" width="65" runat="server" ID="ProductImg"/>
                            </td>
                            <td>
                                <a alt="" runat="server" ID="ProductLink"></a>
                            </td>
                            <td class="price" style="text-align: right;" runat="server" ID="PriceTd"></td>
                            <td style="text-align: right">
                                <input type="text" runat="server" ID="QuantityTxt" ClientIDMode="Static" style="width: 30px;"/>
                            </td>
                            <td class="price" style="text-align: right;" runat="server" ID="SumPriceTd">
                            </td>
                            <td style="text-align: center;">
                                <img src="/Images/Update.png" alt="更新" title="更新" class="UpdateShoppingCartItemButton" runat="server" ClientIDMode="Static" ID="UpdateImg"/>
                            </td>
                            <td style="text-align: center;">
                                <img src="/Images/Delete.png" alt="删除" title="删除" class="DeleteShoppingCartItemButton" runat="server" ClientIDMode="Static" ID="DeleteImg"/>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            <tfoot>
                <tr>
                    <td>&nbsp;</td>
                    <td style="text-align: right; font-weight: bold;">总计</td>
                    <td>&nbsp;</td>
                    <td style="text-align: right;" runat="server" ID="SumQuantityTd"></td>
                    <td class="price" style="text-align: right;" runat="server" ID="TotalSumPrice"></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </tfoot>
        </table>
    </div>
<br />
<div id="checkout">
        <form action="/Home/Checkout" id="CheckoutForm">
            <span>
                <a href="javascript:if (confirm('是否确认购买？')) document.getElementById('CheckoutForm').submit()">确认购买</a>
            </span>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsContent" runat="server">
    <script type="text/javascript">
        function IsNumeric(input) {
            return (input - 0) == input && input.length > 0;
        }

        $(function () {
            $(".UpdateShoppingCartItemButton").click(function () {
                var buttonID = $(this).attr('id');
                var qid = buttonID.replace('update_', 'quantity_');
                var itemID = buttonID.replace('update_', '');
                var quantity = $('#' + qid).val();
                var postUrl = '/Home/UpdateShoppingCartItem';
                var redirectUrl = '/Home/ShoppingCart';

                if (!IsNumeric(quantity)) {
                    alert('输入的数量值必须是数值。');
                    return;
                }

                var intQuantity = parseInt(quantity);
                if (intQuantity <= 0) {
                    alert('输入的数量值必须是大于或等于1的数值。');
                    window.location.href = redirectUrl;
                    return;
                }

                $.ajax({
                    type: "POST",
                    url: postUrl,
                    data: { shoppingCartItemID: itemID, quantity: intQuantity },
                    success: function (msg) {
                        window.location.href = redirectUrl;
                    }
                });
            });

            $('.DeleteShoppingCartItemButton').click(function () {
                if (confirm('是否确定要删除所选商品？')) {
                    var buttonID = $(this).attr('id');
                    var itemID = buttonID.replace('delete_', '');
                    var postUrl = '/Home/DeleteShoppingCartItem';
                    var redirectUrl = '/Home/ShoppingCart';

                    $.ajax({
                        type: "POST",
                        url: postUrl,
                        data: { shoppingCartItemID: itemID },
                        success: function (msg) {
                            window.location.href = redirectUrl;
                        }
                    });
                }
            });
        });
    </script>
</asp:Content>
