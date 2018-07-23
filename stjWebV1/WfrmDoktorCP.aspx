<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmDoktorCP.aspx.cs" Inherits="stjWebV1.WfrmDoktorCP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <Html><head>
        <link href="Yoneticicss.css" rel="stylesheet" />
    </head></Html>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            height: 40px;
        }
        .auto-style8 {
            height: 20px;
        }
        .auto-style9 {
            height: 20px;
            width: 23px;
        }
        .auto-style11 {
            width: 23px;
        }
        .auto-style12 {
            height: 40px;
            width: 23px;
        }
        .auto-style13 {
            border-radius: 10px;
            border: 2px solid #456879;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8"><strong></strong></td>
            <td class="auto-style8"><strong></strong></td>
            <td colspan="2" class="auto-style8"><strong>Program</strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>İl</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpIl" runat="server" CssClass="auto-style13" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpIl_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                </strong>
            </td>
            <td colspan="2" rowspan="5"><strong>
                <asp:ListBox ID="lbCpProgram" runat="server" CssClass="auto-style13" Width="250px" Height="206px" Font-Bold="True" AutoPostBack="True"></asp:ListBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>İlçe</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpİlce" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpİlce_SelectedIndexChanged">
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Hastane</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpHastane" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpHastane_SelectedIndexChanged">
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Klinik</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpKlinik" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpKlinik_SelectedIndexChanged">
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Doktor</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpDoktor" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpDoktor_SelectedIndexChanged">
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Gün</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpGun" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbCpGun_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Pazartesi</asp:ListItem>
                    <asp:ListItem>Salı</asp:ListItem>
                    <asp:ListItem>Çarşamba</asp:ListItem>
                    <asp:ListItem>Perşembe</asp:ListItem>
                    <asp:ListItem>Cuma</asp:ListItem>
                </asp:DropDownList>
                </strong>
            </td>
            <td rowspan="2" class="auto-style2"><strong>
                <asp:Button ID="btnCpEkle" runat="server" CssClass="btn" Height="45px" Width="87px"   Font-Bold="True" Text="Ekle" OnClick="btnCpEkle_Click" />
                </strong></td>
            <td rowspan="2"><strong>
                <asp:Button ID="btnCpSil" runat="server" CssClass="btn" Width="87px" Height="45px" Font-Bold="True" Text="Sil" OnClick="btnCpSil_Click" />
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style3"><strong>Saat</strong></td>
            <td class="auto-style3">
                <strong>
                <asp:DropDownList ID="cmbCpSaat" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True">
                </asp:DropDownList>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td><strong></strong></td>
            <td><strong></strong></td>
            <td class="auto-style2"><strong></strong></td>
            <td><strong></strong></td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
   
</asp:Content>
