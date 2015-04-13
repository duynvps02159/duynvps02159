Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class dangnhap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"

        Dim connect As SqlConnection = New SqlConnection(someeconnect)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_hang where Ma_KH='" & TextBox1.Text & "' and Ten_KH='" & TextBox2.Text & "' ", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                hethongdulieu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu")
            End If


        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

