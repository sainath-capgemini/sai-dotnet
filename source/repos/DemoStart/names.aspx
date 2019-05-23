<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="names.aspx.cs" Inherits="DemoStart.names" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 70%;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<table align="center" cellpadding="6" cellspacing="6" class="auto-style1">
				<tr>
					<td>
						<asp:Label ID="lblSelectName" runat="server" Text="SelectName"></asp:Label>
					</td>
					<td>
						<asp:DropDownList ID="ddlNames" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlNames_SelectedIndexChanged">
						</asp:DropDownList>
					</td>
				</tr>
				<tr>
					<td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
				</tr>
			</table>
        </div>
    	<p>
			&nbsp;</p>
    </form>
</body>
</html>
