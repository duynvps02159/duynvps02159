Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class chitietsp
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlKH As New SqlDataAdapter("select * from Chitiet_hd", connect)
        Dim tb As New DataTable
        Try
            sqlKH.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuchitiethd.DataSource = tb
        connect.Close()
    End Sub
    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        khachhang.Show()
        Me.Close()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        sanpham.Show()
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

    Private Sub ChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtSảnPhẩmToolStripMenuItem.Click
    
    End Sub

    Private Sub chitietsp_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from chitiet_hd", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuchitiethd.DataSource = tb
        connect.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Chitiet_hd Values (@SL_Hoadon, @HoaDon_SP_Ma_HD, @San_Pham_Ma_SP)"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@SL_Hoadon", slhoadontxt.Text)
            dps.Parameters.AddWithValue("@HoaDon_SP_Ma_HD", sp_mahdtxt.Text)
            dps.Parameters.AddWithValue("@San_Pham_Ma_SP", sp_masptxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitiethd.DataSource = tb
        bangdulieuchitiethd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Chitiet_hd SET SL_Hoadon = @SL_Hoadon, HoaDon_SP_Ma_HD = @HoaDon_SP_Ma_HD, San_Pham_Ma_SP = @San_Pham_Ma_SP"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@SL_Hoadon", slhoadontxt.Text)
            dps.Parameters.AddWithValue("@HoaDon_SP_Ma_HD", sp_mahdtxt.Text)
            dps.Parameters.AddWithValue("@San_Pham_Ma_SP", sp_masptxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitiethd.DataSource = tb
        bangdulieuchitiethd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Chitiet_hd where SL_Hoadon = @SL_Hoadon"
        Dim dps As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@SL_Hoadon", slhoadontxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitiethd.DataSource = tb
        bangdulieuchitiethd.DataSource = Nothing
        LoadData()
    End Sub
End Class