Imports System.Data.SqlClient
Partial Class Category1
    Inherits System.Web.UI.Page
    Dim km As New SqlConnection(ConfigurationSettings.AppSettings("cn"))
    Dim CMD As New SqlCommand
    Dim DR As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        km.Open()
        CMD = New SqlCommand("SELECT * FROM AMCategory_Table4", km)
        DR = CMD.ExecuteReader
        DataList6.DataSource = DR
        DataList6.DataBind()
        DR.Close()

        km.Close()
    End Sub
End Class

