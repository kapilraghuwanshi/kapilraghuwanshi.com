Imports System.Data.SqlClient
Partial Class Index
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        km.Open()

        CMD = New SqlCommand("SELECT TOP 3 * FROM Song_Table3", km)
        DR = CMD.ExecuteReader
        DataList1.DataSource = DR
        DataList1.DataBind()
        DR.Close()
        CMD = New SqlCommand("SELECT TOP 3 * FROM Videos_Table6", km)
        DR = CMD.ExecuteReader
        DataList5.DataSource = DR
        DataList5.DataBind()
        DR.Close()

        km.Close()
    End Sub
End Class
