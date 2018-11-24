Imports System.Data.SqlClient
Partial Class Podcasts
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("PCID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Podcasts_Table12 where PCID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList12.DataSource = DR
        DataList12.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

