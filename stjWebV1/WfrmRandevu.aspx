<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmRandevu.aspx.cs" Inherits="stjWebV1.WfrmRandevu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="CssRandevu.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2{
            width:950px;
            height:300px;
        }
        .auto-style3 {
            width: 100%;
        }
    
        .auto-style4 {
            height: 40px;
            
        }
      
    
        .auto-style5 {
            border-right: 1px solid #3366FF;
            border-top: 1px solid #3366FF;
            border-bottom: 1px solid #3366FF;
            border-left: 4px solid #3366FF;
            font-weight: bold;
            width: 200px;
        }
      
    
        .auto-style6 {
            width: 32px;
        }
        .auto-style7 {
            height: 40px;
            width: 32px;
        }
      
    
        .auto-style9 {
            width: 400px;
            height: 45px;
            background: #4869b2;
            color: #ffffff;
            font-weight: bold;
            text-align: center;
            font-size: xx-large;
        }
      
    
    </style>
    <script>
   
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="ustResim">
            <img class="auto-style2" src="Resimler/yöneticiUstResim.jpg"/></div>

        <div class="bosluk">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div id="AnaDiv">
            <div id="Sayfalar">

        <div id="butondiv">
               
                <asp:Button ID="btnRandevual" CssClass="button" runat="server" Text="Randevu Al" OnClick="btnRandevual_Click" />
                <asp:Button ID="btnRandevuGoruntule" CssClass="button" runat="server" Text="Randevu Görüntüle" OnClick="btnRandevuGoruntule_Click" />
                
               
                </div>

                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <div class="ViewKutusu">
                            <table class="auto-style3">
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Şehir</strong></td>
                                    <td class="auto-style4">
                                        <asp:DropDownList ID="cmbSehir" runat="server" AutoPostBack="True" CssClass="cmb" OnSelectedIndexChanged="cmbSehir_SelectedIndexChanged">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4" >
                                        <strong>ilçe</strong></td>
                                    <td>
                                        <asp:DropDownList ID="cmbIlce" runat="server" AutoPostBack="True" CssClass="cmb" OnSelectedIndexChanged="cmbIlce_SelectedIndexChanged">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Hastane</strong></td>
                                    <td>
                                        <asp:DropDownList ID="cmbHastane" runat="server" AutoPostBack="True" CssClass="cmb" OnSelectedIndexChanged="cmbHastane_SelectedIndexChanged">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Klinik</strong></td>
                                    <td>
                                        <asp:DropDownList ID="cmbKlinik" runat="server" AutoPostBack="True" CssClass="cmb" OnSelectedIndexChanged="cmbKlinik_SelectedIndexChanged">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Doktor</strong></td>
                                    <td>
                                        <asp:DropDownList ID="cmbDoktor" runat="server" AutoPostBack="True" CssClass="cmb" OnSelectedIndexChanged="cmbDoktor_SelectedIndexChanged">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Tarih</strong></td>
                                    <td>
                                        <asp:TextBox ID="txtTarih"  runat="server" AutoPostBack="True" CssClass="tb" TextMode="Date" OnTextChanged="txtTarih_TextChanged"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">&nbsp;</td>
                                    <td class="auto-style4">
                                        <strong>Açıklama</strong></td>
                                    <td>
                                        <asp:TextBox ID="txtAciklama" runat="server" AutoPostBack="True" CssClass="auto-style5" Height="77px" TextMode="MultiLine" Width="201px"></asp:TextBox>
                                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <%--<asp:Button ID="btnOnayla" runat="server" OnClick="btnRandevuOnayla_Click" Text="ONAYLA" Visible="false" />--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <div class="ViewKutusu">

<%--                          BURARAFSFSDGSHFJGHJKHJKHGFDSDFHJKGH--%>
                            <asp:ListView ID="ListView1"  runat="server" DataSourceID="randevuBilgi">
                                
                                <AlternatingItemTemplate>
                                    <tr class="tabloSatir">
                                        <td>
                                            <asp:Label ID="Hastane_AdıLabel" runat="server" Text='<%# Eval("[Hastane Adı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="KlinikLabel" runat="server" Text='<%# Eval("Klinik") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="Adı_SoyadıLabel" runat="server" Text='<%# Eval("[Adı Soyadı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="RandevuTarihiLabel" runat="server" Text='<%# Eval("RandevuTarihi") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="GunLabel" runat="server" Text='<%# Eval("Gun") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="SaatLabel" runat="server" Text='<%# Eval("Saat") %>' />
                                        </td>
                                    </tr>
                                </AlternatingItemTemplate>
                                <EditItemTemplate>
                                    <tr class="tabloSatir">
                                        <td>
                                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Hastane_AdıTextBox" runat="server" Text='<%# Bind("[Hastane Adı]") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="KlinikTextBox" runat="server" Text='<%# Bind("Klinik") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Adı_SoyadıTextBox" runat="server" Text='<%# Bind("[Adı Soyadı]") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="RandevuTarihiTextBox" runat="server" Text='<%# Bind("RandevuTarihi") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GunTextBox" runat="server" Text='<%# Bind("Gun") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="SaatTextBox" runat="server" Text='<%# Bind("Saat") %>' />
                                        </td>
                                    </tr>
                                </EditItemTemplate>
                                <EmptyDataTemplate>
                                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                        <tr>
                                            <td>No data was returned.</td>
                                        </tr>
                                    </table>
                                </EmptyDataTemplate>
                                <InsertItemTemplate>
                                    <tr style="">
                                        <td>
                                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Hastane_AdıTextBox" runat="server" Text='<%# Bind("[Hastane Adı]") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="KlinikTextBox" runat="server" Text='<%# Bind("Klinik") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Adı_SoyadıTextBox" runat="server" Text='<%# Bind("[Adı Soyadı]") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="RandevuTarihiTextBox" runat="server" Text='<%# Bind("RandevuTarihi") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GunTextBox" runat="server" Text='<%# Bind("Gun") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="SaatTextBox" runat="server" Text='<%# Bind("Saat") %>' />
                                        </td>
                                    </tr>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <tr class="tabloSatir">
                                        <td>
                                            <asp:Label ID="Hastane_AdıLabel" runat="server" Text='<%# Eval("[Hastane Adı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="KlinikLabel" runat="server" Text='<%# Eval("Klinik") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="Adı_SoyadıLabel" runat="server" Text='<%# Eval("[Adı Soyadı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="RandevuTarihiLabel" runat="server" Text='<%# Eval("RandevuTarihi") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="GunLabel" runat="server" Text='<%# Eval("Gun") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="SaatLabel" runat="server" Text='<%# Eval("Saat") %>' />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table runat="server">
                                        <tr runat="server">
                                            <td runat="server">
                                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                                    <tr runat="server" class="tabloSatir">
                                                        <th runat="server">Hastane Adı</th>
                                                        <th runat="server">Klinik</th>
                                                        <th runat="server">Adı Soyadı</th>
                                                        <th runat="server">RandevuTarihi</th>
                                                        <th runat="server">Gun</th>
                                                        <th runat="server">Saat</th>
                                                    </tr>
                                                    <tr id="itemPlaceholder" runat="server">
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                                                <asp:DataPager ID="DataPager1" runat="server">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                                    </Fields>
                                                </asp:DataPager>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <SelectedItemTemplate>
                                    <tr style="background-color: #E2DED6;font-weight: bold; color: #333333;">
                                        <td>
                                            <asp:Label ID="Hastane_AdıLabel" runat="server" Text='<%# Eval("[Hastane Adı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="KlinikLabel" runat="server" Text='<%# Eval("Klinik") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="Adı_SoyadıLabel" runat="server" Text='<%# Eval("[Adı Soyadı]") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="RandevuTarihiLabel" runat="server" Text='<%# Eval("RandevuTarihi") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="GunLabel" runat="server" Text='<%# Eval("Gun") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="SaatLabel" runat="server" Text='<%# Eval("Saat") %>' />
                                        </td>
                                    </tr>
                                </SelectedItemTemplate>
                            </asp:ListView>
                            <asp:SqlDataSource ID="randevuBilgi" runat="server" ConnectionString="<%$ ConnectionStrings:StajyerV3ConnectionString %>" SelectCommand="prc_tblRandevuBilgi_Select" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="Label1" DefaultValue="" Name="num" PropertyName="Text" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>

                          
                        </div>
                    </asp:View>
                    
                </asp:MultiView>

            </div>
            <div id="RandevuSaatdiv">
                <div class="auto-style9">Randevu Saatleri</div>
                 <asp:Panel ID="p1"    runat="server">

                  <asp:Label ID="lblmsj"  runat="server" Text=""></asp:Label>
                 </asp:Panel>        
   

            </div>
        </div>

        


 <%--   <div class="auto-style1">
        <asp:Panel ID="p1"   runat="server">
        </asp:Panel>        
    <asp:Label ID="lblmsj"  runat="server" Text=""></asp:Label>
    </div>--%>
    </form>
</body>
</html>
