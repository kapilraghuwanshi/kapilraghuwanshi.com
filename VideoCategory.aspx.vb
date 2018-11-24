Imports System.Data.SqlClient
Partial Class VideoCategory
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("AMID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM VideoCategory_Table5 where AMID=" & kp & " ", km)
        DR = CMD.ExecuteReader
        DataList9.DataSource = DR
        DataList9.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

