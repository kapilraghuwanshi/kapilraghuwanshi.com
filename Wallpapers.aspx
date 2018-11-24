<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Wallpapers.aspx.vb" Inherits="Wallpapers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:DataList ID="DataList16" runat="server">
    <ItemTemplate> 
          <table>
            <tr>
                 <td style=" width:200PX; height:20PX;"> 
                   <%# Eval("WNAME")%> 
                </td>
            </tr>
             <tr>
             <td style=" width:200PX; height:20PX;">
                  <a href='<%# Eval("WALLPAPERFILE")%>' target="_blank">
                  Download </a>
              </td>
              </tr> 
          </table>
       </ItemTemplate>


    </asp:DataList>
    
    </form>
</body>
</html>
