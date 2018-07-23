<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmYoneticiEkle.aspx.cs" Inherits="stjWebV1.WfrmYoneticiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <Html><head>
        <link href="Yoneticicss.css" rel="stylesheet" />
    </head></Html>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 40px;
        }
        .auto-style5 {
            border-radius: 10px;
            border: 2px solid #456879;
        }
        .auto-style6 {
            width: 106px;
        }
        .auto-style7 {
            border-radius: 10px;
            outline-width: medium;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #777;
            margin-left: 0px;
        }
        .auto-style8 {
            width: 24px;
        }
        .auto-style10 {
            height: 41px;
            width: 24px;
        }
        .auto-style11 {
            height: 41px;
        }
        .auto-style12 {
            height: 40px;
            width: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong></strong></td>
            <td><strong></strong></td>
            <td colspan="2"><strong>Yöneticiler</strong></td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11"><strong>Adı</strong></td>
            <td class="auto-style11"><strong>
                <asp:TextBox ID="txtYonAd" runat="server" CssClass="txt" Width="190px" Height="20px" Font-Bold="True"></asp:TextBox>
                </strong></td>
            <td colspan="2" rowspan="3"><strong>
                <asp:ListBox ID="lbYonlist" runat="server" Font-Bold="True" CssClass="auto-style5" Width="194px" Height="133px" AutoPostBack="True"></asp:ListBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11"><strong>Soyadı</strong></td>
            <td class="auto-style11"><strong>
                <asp:TextBox ID="txtYonSoyad" runat="server" CssClass="txt" Width="190px" Height="20px" Font-Bold="True"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>TC</strong></td>
            <td class="auto-style3"><strong>
                <asp:TextBox ID="txtYonTc" CssClass="txt" Width="190px" Height="20px" runat="server" Font-Bold="True"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Şifre</strong></td>
            <td class="auto-style3"><strong>
                <asp:TextBox ID="txtYonsifre" CssClass="txt" Width="190px" Height="20px" runat="server" Font-Bold="True" TextMode="Password"></asp:TextBox>
                </strong></td>
            <td rowspan="2" class="auto-style6"><strong>
                <asp:Button ID="btnYonEkle" runat="server" CssClass="btn" Width="87px" Height="45px" Font-Bold="True" Text="Ekle" OnClick="btnYonEkle_Click" />
                </strong></td>
            <td rowspan="2"><strong>
                <asp:Button ID="btnYonSil" runat="server" CssClass="auto-style7" Width="87px" Height="45px"  Font-Bold="True" Text="Sil" OnClick="btnYonSil_Click" />
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Şifre Tekrar</strong></td>
            <td class="auto-style3"><strong>
                <asp:TextBox ID="txtYonSifreTekrar" CssClass="txt" Width="190px" Height="20px" runat="server" Font-Bold="True" TextMode="Password"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong></strong></td>
            <td><strong></strong></td>
            <td class="auto-style6"><strong></strong></td>
            <td><strong></strong></td>
        </tr>
    </table>
</asp:Content>
