Imports System.Data.SqlClient
Partial Class Wallpapers
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("WCID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Wallpapers_Table14 where WCID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList16.DataSource = DR
        DataList16.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

