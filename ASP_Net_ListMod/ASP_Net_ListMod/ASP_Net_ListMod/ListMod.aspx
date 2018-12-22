<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListMod.aspx.cs" Inherits="ListMod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .ListMod_div{
            float:left;
            
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            This is a form that formats a list of items.
        </div>

        <div class="ListMod_div"><textarea id="txtBx_Source" cols="20" name="S2" rows="2"></textarea></div>
        <div class="ListMod_div"><input type="checkbox" id="chkBx_SeparateLines"/>Separate Lines</div>
        <div class="ListMod_div">
            <textarea id="txtBx_Result" cols="20" name="S1" rows="2"></textarea></div>
        <div style="clear:both"></div>
        <div class="ListMod_div"></div>
        <asp:Button ID="btn_Process" runat="server" OnClick="btn_Process_Click" Text="Process Result" />
    </form>
</body>
</html>
