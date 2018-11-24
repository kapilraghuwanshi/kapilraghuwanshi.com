<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Softwares.aspx.vb" Inherits="Softwares" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:DataList ID="DataList14" runat="server">
    <ItemTemplate> 
          <table>
            <tr>
                 <td style=" width:200PX; height:20PX;"> 
                   <%# Eval("SFNAME")%> 
                </td>
            </tr>
             <tr>
             <td style=" width:200PX; height:20PX;">
                  <a href='<%# Eval("SOFTWAREFILE")%>' target="_blank">
                  Download </a>
              </td>
              </tr> 
          </table>
       </ItemTemplate>
    </asp:DataList>
    </form>
</body>
</html>
