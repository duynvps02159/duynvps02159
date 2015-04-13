Public Class hethongdulieu

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        khachhang.Show()
        Me.Close()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class