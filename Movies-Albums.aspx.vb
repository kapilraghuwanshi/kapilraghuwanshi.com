Imports System.Data.SqlClient
Partial Class Movies_Albums
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("CID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM MovieAlbums_Table2 where CID=" & kp & " ", km)
        DR = CMD.ExecuteReader
        DataList3.DataSource = DR
        DataList3.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class
