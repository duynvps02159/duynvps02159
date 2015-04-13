Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class hoadon
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlKH As New SqlDataAdapter("select * from HoaDon_sp", connect)
        Dim tb As New DataTable
        Try
            sqlKH.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuhd.DataSource = tb
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

    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        loaisp.Show()
        Me.Close()
    End Sub

    Private Sub ChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtSảnPhẩmToolStripMenuItem.Click
        chitietsp.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from HoaDon_SP", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuhd.DataSource = tb
        connect.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into HoaDon_SP Values (@Ma_HD, @TongTien, @Thoigian_lap, @Khach_hang_ma_KH)"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_HD", mahoadontxt.Text)
            dps.Parameters.AddWithValue("@TongTien", tongtientxt.Text)
            dps.Parameters.AddWithValue("@Thoigian_lap", tglaptxt.Text)
            dps.Parameters.AddWithValue("@Khach_hang_ma_KH", kh_makhtxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuhd.DataSource = tb
        bangdulieuhd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE HoaDon_SP SET Ma_HD = @Ma_HD, Tongtien = @Tongtien, Thoigian_lap = @Thoigian_lap, Khach_hang_ma_KH = @Khach_hang_ma_KH WHERE Ma_HD = @Ma_HD"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_HD", mahoadontxt.Text)
            dps.Parameters.AddWithValue("@Tongtien", tongtientxt.Text)
            dps.Parameters.AddWithValue("@Thoigian_lap", tglaptxt.Text)
            dps.Parameters.AddWithValue("@Khach_hang_ma_KH", kh_makhtxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuhd.DataSource = tb
        bangdulieuhd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from HoaDon_SP where Ma_HD = @Ma_HD"
        Dim dps As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_HD", mahoadontxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuhd.DataSource = tb
        bangdulieuhd.DataSource = Nothing
        LoadData()
    End Sub
End Class