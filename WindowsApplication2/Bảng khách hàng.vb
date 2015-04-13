Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class khachhang
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlKH As New SqlDataAdapter("select * from Khach_hang", connect)
        Dim tb As New DataTable
        Try
            sqlKH.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieusp.DataSource = tb
        connect.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Khach_hang Values (@Ma_KH, @Ten_KH, @SDT, @Diachi)"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_KH", makhtxt.Text)
            dps.Parameters.AddWithValue("@Ten_KH", tenkhtxt.Text)
            dps.Parameters.AddWithValue("@SDT", sdttxt.Text)
            dps.Parameters.AddWithValue("@diachi", diachitxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp.DataSource = tb
        bangdulieusp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Khach_hang where Ma_KH = @Ma_KH"
        Dim dps As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_KH", makhtxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp.DataSource = tb
        bangdulieusp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Khach_hang SET Ma_KH = @Ma_KH, Ten_KH = @Ten_KH, SDT = @SDT, Diachi = @Diachi WHERE Ma_KH = @Ma_KH"
        Dim dps As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            dps.Parameters.AddWithValue("@Ma_KH", makhtxt.Text)
            dps.Parameters.AddWithValue("@Ten_KH", tenkhtxt.Text)
            dps.Parameters.AddWithValue("@SDT", sdttxt.Text)
            dps.Parameters.AddWithValue("@DiaChi", diachitxt.Text)
            dps.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieusp.DataSource = tb
        bangdulieusp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someeconnect As String = "workstation id=duynvps02159.mssql.somee.com;packet size=4096;user id=ps02159;pwd=abc12345;data source=duynvps02159.mssql.somee.com;persist security info=False;initial catalog=duynvps02159"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_hang", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieusp.DataSource = tb
        connect.Close()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        dangnhap.Show()
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
        chitietsp.Show()
        Me.Close()
    End Sub
End Class