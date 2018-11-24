Imports System.Data.SqlClient
Partial Class PodcastCategory

    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("AMID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM PodcastCategory_Table11 where AMID=" & kp & " ", km)
        DR = CMD.ExecuteReader
        DataList11.DataSource = DR
        DataList11.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

