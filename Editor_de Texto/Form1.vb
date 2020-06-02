Public Class Form1

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        EDT.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        Open.CheckFileExists = True
        Open.Title = "Abrir Archivo"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            EDT.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        Save.CheckPathExists = True
        Save.Title = "Guardar como"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName)
            myStreamWriter.Write(EDT.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub AbrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem1.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        Open.CheckFileExists = True
        Open.Title = "Abrir Archivo"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            EDT.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        EDT.Copy()
    End Sub

    Private Sub AdelanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdelanteToolStripMenuItem.Click
        EDT.Redo()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        EDT.Cut()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        EDT.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        EDT.SelectAll()
    End Sub

    Private Sub CopiarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTodoToolStripMenuItem.Click
        EDT.Clear()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = EDT.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                EDT.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = EDT.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                EDT.ForeColor = dlg.Color
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
