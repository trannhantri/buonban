Public Class FormQuanly

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.datagridview.Rows.Add(New String() {0, "Xi lanh", 1, 200000})
        Me.datagridview.Rows.Add(New String() {1, "Bo", 1, 600000})
        Me.datagridview.Rows.Add(New String() {2, "Buri", 1, 20000})
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview.CellContentClick

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim dialog = New AddItemDialog()
        dialog.Text = "Tha thu Add"
        dialog.ShowDialog()
        If dialog.DialogResult = DialogResult.OK Then
            datagridview.Rows.Add(New String() {datagridview.Rows.Count, dialog.txt_ten.Text, dialog.txt_soluong.Text, dialog.txt_giaban.Text})
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim index As Integer
        index = datagridview.CurrentRow.Index
        If index > -1 Then
            datagridview.Rows.RemoveAt(index)

            For Each row As DataGridViewRow In datagridview.Rows
                If Not row.Index = index - 1 Then
                    row.Cells(0).Value = index
                    index += 1
                End If
            Next

        End If
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        AddToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ModifireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifireToolStripMenuItem.Click
        ModifireToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ModifireToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModifireToolStripMenuItem1.Click
        Dim index As Integer
        index = datagridview.CurrentRow.Index
        If index > -1 Then
            Dim dialog = New AddItemDialog()
            dialog.Text = "Tha thu Modifire"
            Dim tmp_id As Integer
            tmp_id = datagridview.Rows(index).Cells(0).Value
            dialog.txt_ten.Text = datagridview.Rows(index).Cells(1).Value
            dialog.txt_soluong.Text = datagridview.Rows(index).Cells(2).Value
            dialog.txt_giaban.Text = datagridview.Rows(index).Cells(3).Value
            dialog.ShowDialog()
            If dialog.DialogResult = DialogResult.OK Then
                datagridview.Rows.Item(index).SetValues(New String() {tmp_id, dialog.txt_ten.Text, dialog.txt_soluong.Text, dialog.txt_giaban.Text})
            End If
        End If
    End Sub
End Class
