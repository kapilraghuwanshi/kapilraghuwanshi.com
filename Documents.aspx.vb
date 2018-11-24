Imports System.Data.SqlClient
Partial Class Documents
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("DCID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Documents_Table8 where DCID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList8.DataSource = DR
        DataList8.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

