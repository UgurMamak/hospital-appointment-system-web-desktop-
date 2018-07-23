<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmSaat.aspx.cs" Inherits="stjWebV1.WfrmSaat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <Html><head>
        <link href="Yoneticicss.css" rel="stylesheet" />
    </head></Html>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 103px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            border-radius: 10px;
            border: 2px solid #456879;
            margin-bottom: 33px;
        }
        .auto-style5 {
            text-align: right;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td><strong></strong></td>
            <td colspan="2"><strong></strong></td>
            <td colspan="2"><strong>Saatler</strong></td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Günler</strong></td>
            <td colspan="2" class="auto-style6">
                <asp:DropDownList ID="cmbSaatGun" CssClass="txt" Width="195px" Height="25px" runat="server" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbSaatGun_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Pazartesi</asp:ListItem>
                    <asp:ListItem>Salı</asp:ListItem>
                    <asp:ListItem>Çarşamba</asp:ListItem>
                    <asp:ListItem>Perşembe</asp:ListItem>
                    <asp:ListItem>Cuma</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2" rowspan="3">
                <asp:ListBox ID="lbSaatListe" CssClass="auto-style4" runat="server" Width="238px" Height="200px" Font-Bold="True" AutoPostBack="True"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"><strong>Saat</strong></td>
            <td colspan="2">
                <asp:TextBox ID="txtSaat" CssClass="txt" Width="190px" Height="20px" runat="server" Font-Bold="True" TextMode="Time" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="btnSaatEkle" runat="server" Width="87px" Height="45px" CssClass="btn" Text="Ekle" Font-Bold="True" OnClick="btnSaatEkle_Click" />
            </td>
            <td>
                <asp:Button ID="btnSaatSil" CssClass="btn" Width="87px" Height="45px" runat="server" Text="Sil" Font-Bold="True" OnClick="btnSaatSil_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
