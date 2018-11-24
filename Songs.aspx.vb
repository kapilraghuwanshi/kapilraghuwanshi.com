
Imports System.Data.SqlClient
Partial Class Songs
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("MID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Song_Table3 where MID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList4.DataSource = DR
        DataList4.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class
