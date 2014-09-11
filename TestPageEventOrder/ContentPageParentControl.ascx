<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContentPageParentControl.ascx.cs" Inherits="TestPageEventOrder.ContentPageParentControl" %>
<%@ Register Src="~/ContentPageChildControl.ascx" TagName="ChildControl" TagPrefix="UC" %>
<UC:ChildControl ID="ChildControl1" runat="server" />