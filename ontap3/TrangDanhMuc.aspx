<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TrangDanhMuc.aspx.cs" Inherits="ontap3.TrangDanhMuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Trang Danh Muc</p>
    <div style="width:25%">
        <asp:Repeater ID="rptSanPham" runat="server">
            <ItemTemplate>
                <img src="hinhanh/<%# Eval("Hinh") %>" alt="hinhanh" />
                <p> 
                    <a href="TrangSanPham.aspx?idSanPham=<%# Eval("Id")%>"><%# Eval("Ten") %></a>
                </p>
                <p>
                    <%# Eval("Gia")%>
                </p>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
