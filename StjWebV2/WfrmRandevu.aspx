<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmRandevu.aspx.cs" Inherits="StjWebV2.WfrmRandevu1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link href="Randevu.css" rel="stylesheet" />



    <style type="text/css">
        .auto-style1 {
            background-color: #0061A7;
        }
        .auto-style2 {
            width: 100%;
            height: 38px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            width: 132px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
        .auto-style7 {
            width: 92px;
            height: 42px;
        }
        .auto-style8 {
            height: 42px;
            width: 1px;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            height: 41px;
        }
        .newStyle1 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style11 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            height: 41px;
            width: 120px;
        }
        .auto-style12 {
            width: 38px;
        }
        .auto-style14 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            height: 41px;
            width: 38px;
        }
        .auto-style15 {
            width: 79px;
        }
        .auto-style16 {
            width: 120px;
        }
        .auto-style18 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            width: 120px;
        }
        .auto-style19 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            width: 120px;
            height: 29px;
        }
        .auto-style20 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            width: 38px;
        }
        .newStyle2 {
            color: #FFFFFF;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style21 {
            background-color: #0061A7;
            height: 44px;
        }
        .auto-style22 {
            margin-top: 0px;
        }
        .newStyle3 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
            color: #FFFFFF;
        }
        .auto-style23 {
            height: 29px;
        }
        .auto-style24 {
            height: 40px;
        }
        .auto-style34 {
            margin-left: 20px;
            width: 417px;
        }
        .newStyle18 {
            color: #124D77;
            font-size: large;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .newStyle19 {
            color: #FFFFFF;
            font-size: small;
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
        .auto-style35 {
            margin-left: 29px;
        }

        </style>
</head>
<body>
    <form id="form1" runat="server">


        <div id="divUstResim">
            <asp:Image ID="Image1" runat="server" Height="350px" ImageUrl="~/Resimler/cropped-health_bg2.jpg" Width="1000px" />
        </div>

        <div class="bosluk">
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div id="buyuksayfa">
            <div id="randevual">
                <div class="auto-style1">
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style7">
                                <asp:Button ID="Button1" runat="server" BackColor="#0061A7" BorderStyle="None" ForeColor="White" Height="38px" OnClick="Button1_Click" Text="Randevu Al" Width="116px" />
                            </td>
                            <td class="auto-style8"></td>
                            <td class="auto-style3">
                                <asp:Button ID="Button2" runat="server" BackColor="#0061A7" BorderStyle="None" ForeColor="White" Height="38px" Text="Randevu Geçmişi" Width="131px" OnClick="Button2_Click" />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                    </table>
                </div>
                <div>
                    <div>
                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View5" runat="server">
                                <div>
                                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                                        <AlternatingItemTemplate>
                                            <tr class="dene">
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
                                            <tr class="dene">
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
                                            <tr class="dene">
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
                                                            <tr runat="server" class="dene">
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
                                                    <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                                                </tr>
                                            </table>
                                        </LayoutTemplate>
                                        <SelectedItemTemplate>
                                            <tr class="dene">
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
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StajyerV3ConnectionString %>" SelectCommand="prc_tblRandevuBilgi_Select" SelectCommandType="StoredProcedure">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="Label2" DefaultValue="" Name="num" PropertyName="Text" Type="Int32" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </div>
                            </asp:View>
                            <asp:View ID="View1" runat="server">
                                <table class="auto-style9">
                                    <tr>
                                        <td class="auto-style12">&nbsp;</td>
                                        <td class="auto-style16">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td class="auto-style15">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20"></td>
                                        <td class="auto-style18">İl:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:DropDownList ID="cmbSehir" runat="server" AutoPostBack="True" CssClass="cmb" Height="26px" OnSelectedIndexChanged="cmbSehir_SelectedIndexChanged" Width="210px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20"></td>
                                        <td class="auto-style18">İlçe:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:DropDownList ID="cmbIlce" runat="server" AutoPostBack="True" CssClass="cmb" Height="26px" OnSelectedIndexChanged="cmbIlce_SelectedIndexChanged" Width="210px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20"></td>
                                        <td class="auto-style18">Hastane:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:DropDownList ID="cmbHastane" runat="server" AutoPostBack="True" CssClass="cmb" Height="26px" OnSelectedIndexChanged="cmbHastane_SelectedIndexChanged" Width="210px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20"></td>
                                        <td class="auto-style18">Klinik:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:DropDownList ID="cmbKlinik" runat="server" AutoPostBack="True" CssClass="cmb" Height="26px" OnSelectedIndexChanged="cmbKlinik_SelectedIndexChanged" Width="210px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20"></td>
                                        <td class="auto-style18">Doktor:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:DropDownList ID="cmbDoktor" runat="server" AutoPostBack="True" CssClass="cmb" Height="26px" OnSelectedIndexChanged="cmbDoktor_SelectedIndexChanged" Width="210px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style14"></td>
                                        <td class="auto-style11">Tarih:</td>
                                        <td class="auto-style10"></td>
                                        <td class="auto-style10" colspan="3">
                                            <asp:TextBox ID="txtTarih" runat="server" AutoPostBack="True" BorderColor="Black" BorderWidth="1px" Height="26px" TextMode="Date" Width="205px" OnTextChanged="txtTarih_TextChanged"></asp:TextBox>
                                        </td>
                                        <td class="auto-style10"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20" rowspan="3">&nbsp;</td>
                                        <td class="auto-style19">Randevu Açıklama:</td>
                                        <td rowspan="3">&nbsp;</td>
                                        <td id="txtRandevuAciklama" colspan="3" rowspan="2">
                                            <asp:TextBox ID="txtAciklama" runat="server" AutoPostBack="True" CssClass="cmb" Height="127px" TextMode="MultiLine" Width="205px"></asp:TextBox>
                                        </td>
                                        <td rowspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style19">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style18">&nbsp;</td>
                                        <td id="txtRandevuAciklama" colspan="3">&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:View>
                            <asp:View ID="View4" runat="server">
                                <div class="auto-style34">
                                    <span class="newStyle18">
                                    <br />
                                    RANDEVU SİSTEMİ<br />
                                    <br />
                                    </span><span class="newStyle19">Türkiye&#39;de ki devlet hastanelerinden faydalanabilmek için oluşturduğumuz sistemimize öncelikle kayıt olmalısınız.Yukarıda bulunan ikinci butona tıklayarak kaydolma işlemini başlatabilirrsiniz.Eğer daha önceden kaydolduysanız T.C. Kimlik numaranız ve oluşturduğunuz şifreniz ile birinci butona tıklayarak&nbsp; giriş yapabilirsiniz.<br />
                                    <br />
                                    Giriş yaptıktan sonra randevu almak için İl ilçe hastane klinik bilgilerini doldurup bulunan randevu saatlerinden birini seçmeniz gerekmektedir.<br />
                                    <br />
                                    Sağlıklı mutlu günler dileriz.<br />
                                    <br />
                                    <div>
                                    </div>
                                    </span>
                                    <asp:Image ID="Image2" runat="server" CssClass="auto-style35" Height="151px" ImageUrl="~/Resimler/mehmet-akif-ersoy-devlet-hastanesi.jpg" Width="350px" />
                                </div>
                                <br />
                            </asp:View>
                        </asp:MultiView>
                    </div>
                </div>
            </div>
            <div id="dinamikbuton">
                <div class="auto-style21">
                    <h2 class="auto-style24"><span class="newStyle3">&nbsp;</span><asp:Label ID="Label1" runat="server" ForeColor="White" Text="Randevu Saatleri"></asp:Label>
                    </h2>
                    <p>&nbsp;</p>
                </div>
                <div class="auto-style23">
                </div>
            
               
                <div>
                    <asp:Panel ID="p1" runat="server" CssClass="auto-style22">
                    </asp:Panel>
                </div>
                <br />
            </div>
        </div>

    </form>
</body>
</html>
