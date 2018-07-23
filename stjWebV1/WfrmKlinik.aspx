<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmKlinik.aspx.cs" Inherits="stjWebV1.WfrmKlinik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <Html><head>
        <link href="Yoneticicss.css" rel="stylesheet" />
    </head></Html>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            border-radius: 10px;
            border: 2px solid #456879;
        }
        .auto-style4 {
            width: 239px;
        }
        .auto-style5 {
            text-align: right;
            width: 154px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            width: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="2" class="auto-style7"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hastanedeki Bölümler</strong></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong>İL</strong></td>
            <td class="auto-style4">
                <asp:DropDownList ID="cmbKlinikIl" CssClass="txt" runat="server" Font-Bold="True" Width="195px" Height="25px" AutoPostBack="True" OnSelectedIndexChanged="cmbKlinikIl_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="2" rowspan="3" class="auto-style6">
                <asp:ListBox ID="LbHastanediKlinikler" CssClass="auto-style2" runat="server" Font-Bold="True" Height="171px" Width="336px" AutoPostBack="True" OnSelectedIndexChanged="LbHastanediKlinikler_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong>İlçe</strong></td>
            <td class="auto-style4">
                <asp:DropDownList ID="cmbKlinikIlce" CssClass="txt" runat="server" Font-Bold="True" Width="195px" Height="25px" AutoPostBack="True" OnSelectedIndexChanged="cmbKlinikIlce_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong>Hastane</strong></td>
            <td class="auto-style4">
                <asp:DropDownList ID="CmbKlinikHastane" CssClass="txt" runat="server" Font-Bold="True" Width="195px" Height="25px" AutoPostBack="True" OnSelectedIndexChanged="CmbKlinikHastane_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><strong>Klinik</strong></td>
            <td class="auto-style4">
                <asp:ListBox ID="lbKlinik" CssClass="auto-style2" runat="server" Font-Bold="True" Width="194px" Height="112px" AutoPostBack="True"></asp:ListBox>
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnKlinikKaydet" CssClass="btn" runat="server" Text="Kaydet" Height="50px" Width="87px"  Font-Bold="True" OnClick="btnKlinikKaydet_Click" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnKlinikSil" CssClass="btn" runat="server" Text="Sil" Height="50px" Width="87px" Font-Bold="True" OnClick="btnKlinikSil_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
