<%@ Page Title="" Language="C#" MasterPageFile="~/MPYHastane.Master" AutoEventWireup="true" CodeBehind="WfrmDoktorKayit.aspx.cs" Inherits="StjWebV2.WfrmDoktorKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 618px;
        }
        .auto-style3 {
            width: 313px;
            font-size: small;
            height: 22px;
        }
        .auto-style4 {
            width: 269px;
        }
        .auto-style14 {
            width: 128px;
        }
        .auto-style15 {
            width: 102px;
        }
        .auto-style18 {
            margin-left: 30px;
            margin-right: auto;
            border: 1px solid #848484;
            -webkit-border-radius: 30px;
            -moz-border-radius: 30px;
            border-radius: 30px;
            border: 2px solid #848484;
            outline: 0;
            height: 25px;
            width: 275px;
            padding-left: 10px;
            padding-right: 10px;
        }
        .auto-style23 {
            width: 313px;
            height: 34px;
            text-align: center;
        }
        .auto-style27 {
            width: 313px;
            height: 35px;
            text-align: center;
        }
        .auto-style29 {
            width: 313px;
            text-align: center;
        }
        .auto-style30 {
            font-size: small;
            height: 22px;
        }
        .auto-style33 {
            width: 269px;
            font-size: small;
            height: 22px;
        }
        .auto-style35 {
            width: 87px;
        }
        .newStyle1 {
            color: #FFFFFF;
        }
        .auto-style36 {
            color: #FFFFFF;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style33"><strong></strong></td>
            <td class="auto-style3"><strong></strong></td>
            <td class="auto-style30" colspan="2"><strong>
                <span class="auto-style36">&nbsp;&nbsp;&nbsp;&nbsp;
                Doktorlar</span></strong></td>
            <td class="auto-style30"><strong></strong></td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İl:</strong></td>
            <td class="auto-style23">
                <asp:DropDownList ID="cmbDSehir" runat="server" CssClass="auto-style18" Height="30px"  Width="239px" AutoPostBack="True" OnSelectedIndexChanged="cmbDSehir_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td colspan="3" rowspan="7">
                <asp:ListBox ID="lbDoktor" runat="server" CssClass="textbox" Height="345px" Width="330px" AutoPostBack="True" OnSelectedIndexChanged="lbDoktor_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İlçe:</strong></td>
            <td class="auto-style23">
                <asp:DropDownList ID="cmbDIlce" runat="server" CssClass="auto-style18" Height="30px"  Width="239px" AutoPostBack="True" OnSelectedIndexChanged="cmbDIlce_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hastane:</strong></td>
            <td class="auto-style27">
                <asp:DropDownList ID="cmbDHastane" runat="server" CssClass="auto-style18" Height="30px"  Width="239px" AutoPostBack="True" OnSelectedIndexChanged="cmbDHastane_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Klinik:</strong></td>
            <td class="auto-style23">
                <asp:DropDownList ID="cmbDKlinik" runat="server" CssClass="auto-style18" Height="30px"  Width="239px" AutoPostBack="True" OnSelectedIndexChanged="cmbDKlinik_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ad:</strong></td>
            <td class="auto-style29">
                <asp:TextBox ID="txtDAd" runat="server" CssClass="auto-style18" Height="30px" Width="220px" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Soyad:</strong></td>
            <td class="auto-style29">
                <asp:TextBox ID="txtDSoyad" runat="server" CssClass="auto-style18" Height="30px" Width="222px" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="textboxkenar"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tel:</strong></td>
            <td class="auto-style29">
                <asp:TextBox ID="txtDTel" runat="server" CssClass="auto-style18" Height="30px" Width="222px" AutoPostBack="True" TextMode="Phone"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style35">
                <asp:Button ID="btnDKaydet" runat="server" CssClass="textbox" Height="61px" Text="Kaydet" Width="110px" OnClick="btnDKaydet_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btnDGuncelle" runat="server" CssClass="textbox" Height="61px" Text="Güncelle" Width="110px" OnClick="btnDGuncelle_Click" />
            </td>
            <td>
                <asp:Button ID="btnDSil" runat="server" CssClass="textbox" Height="61px" Text="Sil" Width="107px" OnClick="btnDSil_Click" />
            </td>
        </tr>
    </table>
</asp:Content>