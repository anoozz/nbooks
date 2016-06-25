<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="NBooks.Web.Item.List" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
		<Columns>
			<asp:BoundField DataField="Name" HeaderText="Name" />
			<asp:BoundField DataField="SalesDescription" HeaderText="Description" />
		</Columns>
	</asp:GridView>
</asp:Content>
