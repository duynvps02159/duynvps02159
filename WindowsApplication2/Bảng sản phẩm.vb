Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class sanpham
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlKH As New SqlDataAdapter("select * from San_Pham", connect)
        Dim tb As New DataTable
        Try
            sqlKH.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieusp2.DataSource = tb
        connect.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieusp2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        khachhang.Show()
        Me.Close()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        hoadon.Show()
        Me.Close()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        loaisp.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into San_Pham Values (@Ma_SP, @Ten_SP, @Don_gia, @So_Luong, @chitiet_sp)"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_SP", masptxt.Text)
            dps.Parameters.AddWithValue("@Ten_SP", tensptxt.Text)
            dps.Parameters.AddWithValue("@Don_gia", dongiatxt.Text)
            dps.Parameters.AddWithValue("@So_luong", sltxt.Text)
            dps.Parameters.AddWithValue("@Chitiet_SP", chitiet_sp.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp2.DataSource = tb
        bangdulieusp2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE San_Pham SET Ma_SP = @Ma_SP, Ten_SP = @Ten_SP, Don_gia = @Don_gia, So_luong = @So_luong, Chitiet_sp = @Chitiet_sp WHERE Ma_SP = @Ma_SP"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_SP", masptxt.Text)
            dps.Parameters.AddWithValue("@Ten_SP", tensptxt.Text)
            dps.Parameters.AddWithValue("@Don_gia", dongiatxt.Text)
            dps.Parameters.AddWithValue("@So_luong", sltxt.Text)
            dps.Parameters.AddWithValue("@Chitiet_SP", chitiet_sp.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp2.DataSource = tb
        bangdulieusp2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Khach_hang where Ma_SP = @Ma_SP"
        Dim dps As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_SP", masptxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp2.DataSource = tb
        bangdulieusp2.DataSource = Nothing
        LoadData()
    End Sub
End Class