<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="CurrencyConverter.Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.jquery.com/jquery-3.1.0.js" ></script>
        <script>
            //function convert() {
            //    var input_amount = $("#input_amount").val();
            //    var input_currdrp = $('#input_currdrp :selected').text();
            //    var output_currdrp = $('#output_currdrp :selected').text();
            //    if (input_amount === "" || input_amount === 0) {
            //        alert("Please enter value greater than 0!");
            //        return false;
            //    }
            //    else if (input_currdrp === output_currdrp) {
            //        alert("Input & Output Currency should not be same!");
            //        return false;
            //    }
            //    else {
            //        var data = "input_amount=" + input_amount + "&input_currdrp=" + input_currdrp + "&output_currdrp=" + output_currdrp;
            //        $.ajax({
            //            url: "Converter.aspx/Button1_Click",
            //            data: data,
            //            success: function (result) {
            //                $("#output_amount").val(result);
            //            }
            //        });
            //    }
            //}
            function checkDec(el) {
                var ex = /^[0-9]+\.?[0-9]*$/;
                if (ex.test(el.value) == false) {
                    el.value = el.value.substring(0, el.value.length - 1);
                }
            }
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="0">US dollar</asp:ListItem>
            <asp:ListItem Value="1">Euro</asp:ListItem>
            <asp:ListItem Value="2">Japanese Yen</asp:ListItem>
            <asp:ListItem Value="3">German Mark</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="0">US dollar</asp:ListItem>
            <asp:ListItem Value="1">Euro</asp:ListItem>
            <asp:ListItem Value="2">Japanese Yen</asp:ListItem>
            <asp:ListItem Value="3">German Mark</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
