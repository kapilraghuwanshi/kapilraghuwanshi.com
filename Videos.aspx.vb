Imports System.Data.SqlClient
Partial Class Videos
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("VCID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Videos_Table6 where VCID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList10.DataSource = DR
        DataList10.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

