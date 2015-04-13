Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class loaisp
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlKH As New SqlDataAdapter("select * from Loai_SP", connect)
        Dim tb As New DataTable
        Try
            sqlKH.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuloaisp.DataSource = tb
        connect.Close()
    End Sub
    Private Sub Bản_loại_sản_phẩm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        sanpham.Show()
        Me.Close()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        hoadon.Show()
        Me.Close()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click

    End Sub

    Private Sub ChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtSảnPhẩmToolStripMenuItem.Click
        chitietsp.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Loai_SP", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuloaisp.DataSource = tb
        connect.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Loai_SP Values (@ma_loai, @ten_loai)"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@ma_loai", maloaitxt.Text)
            dps.Parameters.AddWithValue("@ten_loai", tenloaitxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuloaisp.DataSource = tb
        bangdulieuloaisp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Loai_SP SET ma_loai = @ma_loai, ten_loai = @ten_loai"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@ma_loai", maloaitxt.Text)
            dps.Parameters.AddWithValue("@ten_loai", tenloaitxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuloaisp.DataSource = tb
        bangdulieuloaisp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Khach_hang where ma_loai = @ma_loai"
        Dim dps As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@ma_loai", maloaitxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuloaisp.DataSource = tb
        bangdulieuloaisp.DataSource = Nothing
        LoadData()
    End Sub
End Class