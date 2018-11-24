Imports System.Data.SqlClient
Partial Class Softwares
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kp As String
        kp = Request.QueryString("SCID")
        km.Open()
        CMD = New SqlCommand("SELECT * FROM Softwares_Table10 where SCID=" & kp & "", km)
        DR = CMD.ExecuteReader
        DataList14.DataSource = DR
        DataList14.DataBind()
        DR.Close()
        km.Close()
    End Sub
End Class

