<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiMstr.Master" AutoEventWireup="true" CodeBehind="WfrmDoktor.aspx.cs" Inherits="stjWebV1.WfrmDoktor" %>
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
        .auto-style3 {
            width: 45px;
        }
        .auto-style4 {
            border-radius: 10px;
            outline-width: medium;
            outline-style: none;
            outline-color: invert;
            border: 2px solid #777;
            margin-left: 0px;
        }
        .auto-style5 {
            width: 121px;
        }
        .auto-style7 {
            width: 147px;
        }
        .auto-style9 {
            width: 147px;
            text-align: center;
        }
        .auto-style10 {
            width: 45px;
            text-align: center;
        }
        .auto-style11 {
            width: 121px;
            text-align: left;
        }
        .auto-style12 {
            width: 18px;
        }
        .auto-style14 {
            height: 40px;
            width: 18px;
        }
        .auto-style15 {
            height: 40px;
        }
        .auto-style16 {
            height: 39px;
            width: 18px;
        }
        .auto-style17 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table class="auto-style1">
        
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="3"><strong>Hastanedeki Doktorlar</strong></td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>İl</strong></td>
            <td class="auto-style15">
                <asp:DropDownList ID="cmbDoktorIl" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbDoktorIl_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td colspan="3" rowspan="5">
                <asp:ListBox ID="lbHastanedekiDktr" runat="server" CssClass="auto-style2" Font-Bold="True" Height="206px" Width="336px" AutoPostBack="True" OnSelectedIndexChanged="lbHastanedekiDktr_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17"><strong>İlçe</strong></td>
            <td class="auto-style17">
                <asp:DropDownList ID="cmbDoktorIlce" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbDoktorIlce_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>Hastane</strong></td>
            <td class="auto-style15">
                <asp:DropDownList ID="cmbDoktorHastane" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbDoktorHastane_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>Klinik</strong></td>
            <td class="auto-style15">
                <asp:DropDownList ID="cmbDoktorKlinik" runat="server" CssClass="txt" Width="195px" Height="25px" Font-Bold="True" AutoPostBack="True" OnSelectedIndexChanged="cmbDoktorKlinik_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>Adı</strong></td>
            <td class="auto-style15">
                <asp:TextBox ID="txtAdi" runat="server" CssClass="txt" Width="190px" Height="20px" Font-Bold="True" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"><strong>Soyadı</strong></td>
            <td class="auto-style15">
                <asp:TextBox ID="txtSoyadi" runat="server" CssClass="txt" Width="190px" Height="20px" Font-Bold="True" AutoPostBack="True"></asp:TextBox>
            </td>
            <td rowspan="2" class="auto-style11">
                <asp:Button ID="btnDoktorEkle" runat="server" CssClass="btn" Font-Bold="True" Height="45px" Width="87px" Text="Kaydet" OnClick="btnDoktorEkle_Click" />
            </td>
            <td rowspan="2" class="auto-style10">
                <asp:Button ID="btnDoktorGuncelle" runat="server" CssClass="btn" Font-Bold="True" Height="45px" Width="87px" Text="Güncelle" OnClick="btnDoktorGuncelle_Click" />
            </td>
            <td rowspan="2" class="auto-style9">
                &nbsp;
                <asp:Button ID="btnDoktorSil" runat="server" CssClass="auto-style4" Height="45px" Width="87px" Font-Bold="True" Text="Sil" OnClick="btnDoktorSil_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17"><strong>Tel</strong></td>
            <td class="auto-style17">
                <asp:TextBox ID="txtTel" runat="server" CssClass="txt" Width="190px" Height="20px" Font-Bold="True" TextMode="Phone" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
