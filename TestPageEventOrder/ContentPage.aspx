<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="ContentPage.aspx.cs" Inherits="TestPageEventOrder.ContentPage" MasterPageFile="~/ChildMaster.Master" %>
<%@ Register Src="~/ContentPageParentControl.ascx" TagName="ParentControl" TagPrefix="UC" %>
<%@ Register Src="~/ContentPageParentControl2.ascx" TagName="ParentControl2" TagPrefix="UC" %>
<asp:Content runat="server" ID="content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <UC:ParentControl runat="server" />
    <UC:ParentControl2 ID="ParentControl1" runat="server" />
</asp:Content>