<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc.aspx.cs" Inherits="DemoStart.calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 70%;
			height: 179px;
		}
		.auto-style2 {
			width: 324px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table cellpadding="6" cellspacing="6" class="auto-style1">
			<tr>
				<td>
					<asp:Label ID="txtFirstNo" runat="server" Text="FirstNo"></asp:Label>
				</td>
				<td class="auto-style2">
					<asp:TextBox ID="txt1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="txtSecondNo" runat="server" Text="SecondNo"></asp:Label>
				</td>
				<td class="auto-style2">
					<asp:TextBox ID="txt2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="txtResult" runat="server" Text="Result"></asp:Label>
				</td>
				<td class="auto-style2">
					<asp:TextBox ID="txtr" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="2">&nbsp;<asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="btnMul" runat="server" OnClick="btnMul_Click" Text="Mul" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:LinkButton ID="lnkNames" runat="server" OnClick="lnkNames_Click">Names</asp:LinkButton>
				</td>
			</tr>
		</table>
    </form>
</body>
</html>
